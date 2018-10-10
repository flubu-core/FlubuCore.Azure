
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Policy
{
     public partial class AzurePolicySetDefinitionUpdateTask : ExternalProcessTaskBase<AzurePolicySetDefinitionUpdateTask>
     {
        
        /// <summary>
        /// Update a policy set definition.
        /// </summary>
        public AzurePolicySetDefinitionUpdateTask(string name = null)
        {
            WithArguments("az policy set-definition update");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// JSON formatted string or a path to a file or uri with such content.
        /// </summary>
        public AzurePolicySetDefinitionUpdateTask Definitions(string definitions = null)
        {
            WithArguments("--definitions");
            if (!string.IsNullOrEmpty(definitions))
            {
                 WithArguments(definitions);
            }

            return this;
        }

        /// <summary>
        /// Display name of policy set definition.
        /// </summary>
        public AzurePolicySetDefinitionUpdateTask DisplayName(string displayName = null)
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
        public AzurePolicySetDefinitionUpdateTask Params(string @params = null)
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
