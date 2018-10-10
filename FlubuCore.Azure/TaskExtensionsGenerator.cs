﻿using System;
using System.Collections.Generic;
using FlubuCore.Azure.Models;
using Scripty.Core;

namespace FlubuCore.Azure
{
    public class TaskExtensionsGenerator : TaskGeneratorBase
    {
        private readonly ScriptContext _context;

        public TaskExtensionsGenerator(ScriptContext context)
        {
            _context = context;
        }

        public void GenerateTaskExtension(TaskExtensions extensions)
        {
            foreach (var subExtension in extensions.SubExtensions)
            {
                GenerateTaskExtension(subExtension);
            }

            _context.Output[extensions.FileName]
                .WriteLine($@"
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
{WriteUsings(extensions.Usings)}
namespace {extensions.Namespace}
{{
    public class {extensions.ExtensionName}
    {{
        {WriteSubExtensionMethods(extensions)}
        {WriteTasks(extensions.Methods)}        
    }}
}}
");
        }

        public string WriteSubExtensionMethods(TaskExtensions extension)
        {
            string methods = string.Empty;

            foreach (var subExtension in extension.SubExtensions)
            {
                methods = $@"{methods}
        public {subExtension.ExtensionName} {subExtension.ExtensionName} ()
        {{
            return new {subExtension.ExtensionName}();
        }}";
            }

            return methods;
        }

        public string WriteTasks(List<ExtensionMethod> task)
        {
            string methods = string.Empty;

            foreach (var method in task)
            {
                methods = $@"{methods}
            public {method.TaskName} {method.MethodName}({WriteParameters(method.Parameters)})
            {{
                return new {method.TaskName}({WriteParams(method.Parameters)});
            }}
";
            }

            return methods;
        }

        public string WriteParams(List<TaskGenerator.Models.Parameter> parameters)
        {
            string ret = string.Empty;

            foreach (var parameter in parameters)
            {
                if (!string.IsNullOrEmpty(ret))
                {
                    ret = $"{ret}, ";
                }

                ret = $"{ret} {ParameterName(parameter.ParameterName)}";
            }

            ret = ret.Trim();
            return ret;
        }

        public string WriteUsings(List<string> usings)
        {
            string ret = string.Empty;
            foreach (var @using in usings)
            {
                ret = $"{ret}using {@using};" + Environment.NewLine;
            }

            return ret;
        }

}
}
