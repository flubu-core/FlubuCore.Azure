using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.TaskGenerator.Models;
using Scripty.Core;

namespace FlubuCore.Azure
{
    public class AzureTaskGenerator : TaskGenerator.TaskGenerator
    {
        public AzureTaskGenerator(ScriptContext context) : base(context)
        {
        }
        
        protected override string WriteParameter(Parameter parameter)
        {
            if (parameter == null)
            {
                return string.Empty;
            }

            return $"{parameter.ParameterType} {parameter.ParameterName} = null";
        }

        protected override string WriteArgument(Argument argument)
        {
            if (argument == null)
            {
                return string.Empty;
            }

            if (argument.Parameter == null)
            {
                return $@"WithArguments(""{argument.ArgumentKey}"");";
            }

            return $@"WithArguments(""{argument.ArgumentKey}"");
            if (!string.IsNullOrEmpty({argument.Parameter.ParameterName}))
            {{
                 WithArguments({argument.Parameter.ParameterName});
            }}
";
        }
    }
}
