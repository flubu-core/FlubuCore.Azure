
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Policy
{
     public partial class AzurePolicyDefinitionCreateTask : ExternalProcessTaskBase<AzurePolicyDefinitionCreateTask>
     {
        
        /// <summary>
        /// Create a policy definition.
        /// </summary>
        public AzurePolicyDefinitionCreateTask(string name = null)
        {
            WithArguments("az policy definition create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Display name of policy definition.
        /// </summary>
        public AzurePolicyDefinitionCreateTask DisplayName(string displayName = null)
        {
            WithArguments("--display-name");
            if (!string.IsNullOrEmpty(displayName))
            {
                 WithArguments(displayName);
            }

            return this;
        }

        /// <summary>
        /// Metadata in space-separated key=value pairs.
        /// </summary>
        public AzurePolicyDefinitionCreateTask Metadata(string metadata = null)
        {
            WithArguments("--metadata");
            if (!string.IsNullOrEmpty(metadata))
            {
                 WithArguments(metadata);
            }

            return this;
        }

        /// <summary>
        /// Mode of the new policy definition.
        /// </summary>
        public AzurePolicyDefinitionCreateTask Mode(string mode = null)
        {
            WithArguments("--mode");
            if (!string.IsNullOrEmpty(mode))
            {
                 WithArguments(mode);
            }

            return this;
        }

        /// <summary>
        /// JSON formatted string or a path to a file or uri with parameter definitions.
        /// </summary>
        public AzurePolicyDefinitionCreateTask Params(string @params = null)
        {
            WithArguments("--params");
            if (!string.IsNullOrEmpty(@params))
            {
                 WithArguments(@params);
            }

            return this;
        }

        /// <summary>
        /// Policy rules in JSON format, or a path to a file containing JSON rules.
        /// </summary>
        public AzurePolicyDefinitionCreateTask Rules(string rules = null)
        {
            WithArguments("--rules");
            if (!string.IsNullOrEmpty(rules))
            {
                 WithArguments(rules);
            }

            return this;
        }
     }
}
