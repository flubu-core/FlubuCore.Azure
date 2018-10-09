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
                            if (parameter.Name.Equals("--description", StringComparison.OrdinalIgnoreCase) || parameter.Name.Equals("--404description", StringComparison.OrdinalIgnoreCase))
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

            tasks.RemoveAll(x => x.TaskName.Contains("List"));
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
