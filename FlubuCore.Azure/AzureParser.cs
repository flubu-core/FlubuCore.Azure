using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using FlubuCore.Azure;
using FlubuCore.Azure.Models;
using FlubuCore.TaskGenerator;
using FlubuCore.TaskGenerator.Models;
using Newtonsoft.Json;
using YamlDotNet.Serialization;

namespace FlubuCore.Azure
{
    public class AzureParser
    {
        private static char[] digits = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public TaskExtensions ToTaskExtensions(List<Task> tasks)
        {
            var taskExtensions = new TaskExtensions();
            taskExtensions.ExtensionName = "Azure";
            taskExtensions.FileName = "Azure.cs";
            taskExtensions.Namespace = "FlubuCore.Azure";
            foreach (var task in tasks)
            {
                if (string.IsNullOrEmpty(task.Parent))
                {
                    taskExtensions.Methods.Add(MapToExtensionMethod(task));
                }
                else
                {
                    var subExtension = taskExtensions.SubExtensions.FirstOrDefault(x => x.ExtensionName == task.Parent);
                    if (subExtension != null)
                    {
                        subExtension.Methods.Add(MapToExtensionMethod(task));
                    }
                    else
                    {
                        subExtension = new TaskExtensions
                        {
                            ExtensionName = task.Parent,
                            FileName = $"{task.Parent}.cs",
                            Namespace = "FlubuCore.Azure",
                        };

                        subExtension.Usings.Add($"FlubuCore.Azure.Tasks.{task.Parent}");
                        subExtension.Methods.Add(MapToExtensionMethod(task));
                        taskExtensions.SubExtensions.Add(subExtension);
                    }
                }
            }

            taskExtensions.Methods = taskExtensions.Methods.Where(x => !taskExtensions.SubExtensions.Any(y => y.ExtensionName == x.MethodName)).ToList();

            return taskExtensions;
        }

        private static ExtensionMethod MapToExtensionMethod(Task task)
        {
            return new ExtensionMethod
            {
                TaskName = task.TaskName,
                MethodName = task.TaskName.RemoveFromBeginning("Azure").RemoveFromEnd("Task"),
                Parameters = task.Constructor.Arguments?.Select(x => x.Parameter).Where(x => x != null).ToList(),
            };
        }

        public List<Task> Parse(List<Models.Azure> azures)
        {
            var tasks = new List<TaskGenerator.Models.Task>();

            foreach (Models.Azure azure in azures)
            {
                foreach (var item in azure.Items)
                {
                    var splitedName = item.Name.Split(' ', '-').ToList();
                    if (splitedName.Count == 1 || splitedName.Contains("List"))
                    {
                        continue;
                    }

                    splitedName.RemoveAt(0);

                    splitedName = splitedName.Select(x => x.FirstCharToUpper()).ToList();
                    
                    TaskGenerator.Models.Task task = new TaskGenerator.Models.Task()
                    {
                        Namespace = "FlubuCore.Azure.Tasks",
                        ProjectName = "FlubuCore.Azure",
                        Methods = new List<Method>(),
                    };

                    task.TaskName = $"Azure{string.Join(string.Empty, splitedName)}Task";

                    string fileName;
                    if (splitedName.Count > 1)
                    {
                        task.Namespace = $"{task.Namespace}.{splitedName[0]}";
                        fileName = $"Tasks\\{splitedName[0]}\\{task.TaskName}.cs";
                        task.Parent = splitedName[0];
                    }
                    else
                    {
                        fileName = $"Tasks\\{task.TaskName}.cs";
                    }

                    task.FileName = fileName;

                    task.Constructor = new Constructor
                    {
                        Summary = item.Summary,
                        Arguments = new List<Argument>(),
                    };

                    task.Constructor.Arguments.Add(new Argument
                    {
                        ArgumentKey = item.Name,
                    });

                    if (item.Parameters != null)
                    {
                        foreach (var parameter in item.Parameters)
                        {
                            if (parameter.Name.Equals("--description", StringComparison.OrdinalIgnoreCase) || parameter.Name.Equals("--404-description", StringComparison.OrdinalIgnoreCase))
                            {
                                continue;
                            }

                            if (parameter.IsRequired.HasValue && parameter.IsRequired.Value)
                            {
                                AddArgumentToConstructor(task, parameter);
                            }

                            if (!parameter.Name.StartsWith("<"))
                            {
                                AddNewMethod(task, parameter);
                            }
                        }
                    }

                    tasks.Add(task);
                }
            }

            tasks.RemoveAll(x => x.TaskName.Contains("List") || x.TaskName.Contains("Show"));
            tasks = tasks.DistinctBy(x => x.TaskName).ToList();
            return tasks;
        }

        private void AddNewMethod(TaskGenerator.Models.Task task, FlubuCore.Azure.Models.Parameter parameter)
        {
            if (parameter.IsRequired.HasValue && parameter.IsRequired.Value)
            {
                return;
            }

            var item = new Method();
            item.MethodName = ParseMethodName(parameter.Name);
            item.MethodSummary = parameter.Summary;
            item.Argument = new Argument
            {
                ArgumentKey = parameter.Name.Split(' ')[0],
                HasArgumentValue = true,
                Parameter = new TaskGenerator.Models.Parameter
                {
                    ParameterType = "string",
                    ParameterName = ParseParameterName(parameter.Name),
                },
            };
            task.Methods.Add(item);
        }

        private void AddArgumentToConstructor(TaskGenerator.Models.Task task, FlubuCore.Azure.Models.Parameter parameter)
        {
            task.Constructor.Arguments.Add(new Argument
            {
                ArgumentKey = parameter.Name.Split(' ')[0],
                HasArgumentValue = true,
                Parameter = new TaskGenerator.Models.Parameter
                {
                    ParameterType = "string",
                    ParameterName = ParseParameterName(parameter.Name),
                },
            });
        }

        public string ParseParameterName(string value)
        {
            var splitedValues = value.Split(' ');
            var names = splitedValues[0].TrimStart('-').TrimStart(digits).Split('-');
            string name = null;
            for (var i = 0; i < names.Length; i++)
            {
                name = i == 0 ? $"{name}{names[i]}" : $"{name}{names[i].FirstCharToUpper()}";
            }

            return name;
        }

        public string ParseMethodName(string value)
        {
            var splitedValues = value.Split(' ');
            var names = splitedValues[0].TrimStart('-').TrimStart(digits).Split('-').Where(x => !string.IsNullOrEmpty(x)).ToList();
            string name = null;
            for (var i = 0; i < names.Count; i++)
            {
                name = $"{name}{names[i].FirstCharToUpper()}";
            }

            return name;
        }
    }
}
