
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Policy
{
     public partial class AzurePolicySetDefinitionCreateTask : ExternalProcessTaskBase<AzurePolicySetDefinitionCreateTask>
     {
        
        /// <summary>
        /// Create a policy set definition.
        /// </summary>
        public AzurePolicySetDefinitionCreateTask(string definitions = null ,  string name = null)
        {
            WithArguments("az policy set-definition create");
WithArguments("--definitions");
            if (!string.IsNullOrEmpty(definitions))
            {
                 WithArguments(definitions);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Display name of policy set definition.
        /// </summary>
        public AzurePolicySetDefinitionCreateTask DisplayName(string displayName = null)
        {
            WithArguments("--display-name");
            if (!string.IsNullOrEmpty(displayName))
            {
                 WithArguments(displayName);
            }

            return this;
        }

        /// <summary>
        /// JSON formatted string or a path to a file or uri with parameter definitions.
        /// </summary>
        public AzurePolicySetDefinitionCreateTask Params(string @params = null)
        {
            WithArguments("--params");
            if (!string.IsNullOrEmpty(@params))
            {
                 WithArguments(@params);
            }

            return this;
        }
     }
}
