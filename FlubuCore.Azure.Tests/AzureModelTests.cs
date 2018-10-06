using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using FlubuCore.Azure.Models;
using FlubuCore.TaskGenerator.Models;
using Microsoft.CodeAnalysis.Diagnostics;
using Newtonsoft.Json;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;
using NJsonSchema.Generation;
using NJsonSchema.Yaml;
using Xunit;
using YamlDotNet.Serialization;
using Parameter = FlubuCore.Azure.Models.Parameter;
using Task = System.Threading.Tasks.Task;


namespace FlubuCore.Azure.Tests
{
    public class AzureModelTests
    {
        [Fact]
        public async Task FromYaml()
        {
            HttpClient client = new HttpClient();
            var response =
                await client.GetAsync(
                    "https://raw.githubusercontent.com/Azure/azure-docs-cli-python/9113bf87/latest/docs-ref-autogen/reference-index.yml");

            File.WriteAllText("test.yml", await response.Content.ReadAsStringAsync());
        }
    }
}
//            var ret = new StringReader (await response.Content.ReadAsStringAsync());
//            var deserializer = new Deserializer();
//            object yamlObject = deserializer.Deserialize(ret);

//            // now convert the object to JSON. Simple!
//            Newtonsoft.Json.JsonSerializer js = new Newtonsoft.Json.JsonSerializer();

//            var w = new StringWriter();
//            js.Serialize(w, yamlObject);
//            string jsonText = w.ToString();

//            var azure = FlubuCore.Azure.Models.Azure.FromJson(jsonText);
//            var tasks = new List<TaskGenerator.Models.Task>();
//            foreach (var item in azure.Items)
//            {
//                TaskGenerator.Models.Task task = new TaskGenerator.Models.Task()
//                {
//                    Namespace = "FlubuCore.Azure",
//                    ProjectName = "FlubuCore.Azure",
//                    Methods = new List<Method>(),
//                };

//                var splitedName = item.Name.Split(" ");
//                if (splitedName.Length == 1)
//                {
//                    continue;
//                }

//                task.TaskName = $"Azure{splitedName[1].FirstCharToUpper()}Task";
//                task.FileName = $"{task.TaskName}.cs";

//                task.Constructor = new Constructor
//                {
//                    Summary = item.Summary,
//                    Arguments = new List<Argument>(),
//                };

//                task.Constructor.Arguments.Add(new Argument
//                {
//                    ArgumentKey = item.Name,
//                });

//                foreach (var parameter in item.Parameters)
//                {
//                    if (parameter.IsRequired.HasValue && parameter.IsRequired.Value)
//                    {
//                        AddArgumentToConstructor(task, parameter);
//                    }

//                    AddNewMethod(task, parameter);
//                }

//                tasks.Add(task);
//            }

//            Assert.NotNull(azure);
//        }

//        private void AddNewMethod(TaskGenerator.Models.Task task, Parameter parameter)
//        {
//            task.Methods.Add(new Method
//            {
//                MethodName = ParseMethodName(parameter.Name),
//                MethodSummary = parameter.Summary,
//                Argument = new Argument
//                {
//                    ArgumentKey = parameter.Name,
//                    HasArgumentValue = true,
//                    Parameter = new TaskGenerator.Models.Parameter
//                    {
//                        ParameterType = "string",
//                        ParameterName = ParseParameterName(parameter.Name),
//                    },
//                },
//            });
//        }

//        private void AddArgumentToConstructor(TaskGenerator.Models.Task task, Parameter parameter)
//        {
//            task.Constructor.Arguments.Add(new Argument
//            {
//                ArgumentKey = parameter.Name,
//                HasArgumentValue = true,
//                Parameter = new TaskGenerator.Models.Parameter
//                {
//                    ParameterType = "string",
//                    ParameterName = ParseParameterName(parameter.Name),
//                },
//            });
//        }

//        public string ParseParameterName(string value)
//        {
//            var splitedValues = value.Split(" ");
//            var names = splitedValues[0].TrimStart('-').Split("-");
//            string name = null;
//            for (var i = 0; i < names.Length; i++)
//            {
//                name = i == 0 ? $"{name}{names[i]}" : $"{name}{names[i].FirstCharToUpper()}";
//            }

//            return name;
//        }
//        public string ParseMethodName(string value)
//        {
//            var splitedValues = value.Split(" ");
//            var names = splitedValues[0].TrimStart('-').Split("-");
//            string name = null;
//            for (var i = 0; i < names.Length; i++)
//            {
//                name = $"{name}{names[i].FirstCharToUpper()}";
//            }

//            return name;
//        }
//    }
//}


