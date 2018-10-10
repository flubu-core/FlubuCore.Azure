
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Policy
{
     public partial class AzurePolicyDefinitionUpdateTask : ExternalProcessTaskBase<AzurePolicyDefinitionUpdateTask>
     {
        
        /// <summary>
        /// Update a policy definition.
        /// </summary>
        public AzurePolicyDefinitionUpdateTask(string name = null)
        {
            WithArguments("az policy definition update");
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
        public AzurePolicyDefinitionUpdateTask DisplayName(string displayName = null)
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
        public AzurePolicyDefinitionUpdateTask Metadata(string metadata = null)
        {
            WithArguments("--metadata");
            if (!string.IsNullOrEmpty(metadata))
            {
                 WithArguments(metadata);
            }

            return this;
        }

        /// <summary>
        /// JSON formatted string or a path to a file or uri with parameter definitions.
        /// </summary>
        public AzurePolicyDefinitionUpdateTask Params(string @params = null)
        {
            WithArguments("--params");
            if (!string.IsNullOrEmpty(@params))
            {
                 WithArguments(@params);
            }

            return this;
        }

        /// <summary>
        /// JSON formatted string or a path to a file with such content.
        /// </summary>
        public AzurePolicyDefinitionUpdateTask Rules(string rules = null)
        {
            WithArguments("--rules");
            if (!string.IsNullOrEmpty(rules))
            {
                 WithArguments(rules);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzurePolicyDefinitionUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzurePolicyDefinitionUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzurePolicyDefinitionUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzurePolicyDefinitionUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
