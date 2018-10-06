using System;
using System.Collections.Generic;
using System.IO;
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
        public List<Task> Parse()
        {
            WebClient client = new WebClient();
            var response = client.DownloadString("https://raw.githubusercontent.com/Azure/azure-docs-cli-python/9113bf87/latest/docs-ref-autogen/reference-index.yml");
            var deserializer = new YamlDotNet.Serialization.Deserializer();
            object yamlObject = deserializer.Deserialize<object>(response);

            Newtonsoft.Json.JsonSerializer js = new Newtonsoft.Json.JsonSerializer();

            var w = new System.IO.StringWriter();
            js.Serialize(w, yamlObject);
            string jsonText = w.ToString();

            var azure = JsonConvert.DeserializeObject<FlubuCore.Azure.Models.Azure>(jsonText);
            var tasks = new List<TaskGenerator.Models.Task>();
            foreach (var item in azure.Items)
            {
                TaskGenerator.Models.Task task = new TaskGenerator.Models.Task()
                {
                    Namespace = "FlubuCore.Azure",
                    ProjectName = "FlubuCore.Azure",
                    Methods = new List<Method>(),
                };

                var splitedName = item.Name.Split(' ');
                if (splitedName.Length == 1)
                {
                    continue;
                }

                task.TaskName = $"Azure{splitedName[1].FirstCharToUpper()}Task";
                task.FileName = $"{task.TaskName}.cs";
                
                task.Constructor = new Constructor
                {
                    Summary = item.Summary,
                    Arguments = new List<Argument>(),
                };

                task.Constructor.Arguments.Add(new Argument
                {
                    ArgumentKey = item.Name,
                });

                foreach (var parameter in item.Parameters)
                {
                    if (parameter.IsRequired.HasValue && parameter.IsRequired.Value)
                    {
                        AddArgumentToConstructor(task, parameter);
                    }

                    AddNewMethod(task, parameter);
                }

                tasks.Add(task);
            }

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
            var names = splitedValues[0].TrimStart('-').Split('-');
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
            var names = splitedValues[0].TrimStart('-').Split('-');
            string name = null;
            for (var i = 0; i < names.Length; i++)
            {
                name = $"{name}{names[i].FirstCharToUpper()}";
            }

            return name;
        }
    }
}
