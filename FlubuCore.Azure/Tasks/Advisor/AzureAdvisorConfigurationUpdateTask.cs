
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Advisor
{
     public partial class AzureAdvisorConfigurationUpdateTask : ExternalProcessTaskBase<AzureAdvisorConfigurationUpdateTask>
     {
        
        /// <summary>
        /// Update Azure Advisor configuration.
        /// </summary>
        public AzureAdvisorConfigurationUpdateTask()
        {
            WithArguments("az advisor configuration update");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Exclude from recommendation generation.
        /// </summary>
        public AzureAdvisorConfigurationUpdateTask Exclude(string exclude = null)
        {
            WithArguments("--exclude");
            if (!string.IsNullOrEmpty(exclude))
            {
                 WithArguments(exclude);
            }

            return this;
        }

        /// <summary>
        /// Include in recommendation generation.
        /// </summary>
        public AzureAdvisorConfigurationUpdateTask Include(string include = null)
        {
            WithArguments("--include");
            if (!string.IsNullOrEmpty(include))
            {
                 WithArguments(include);
            }

            return this;
        }

        /// <summary>
        /// Value for low CPU threshold.
        /// </summary>
        public AzureAdvisorConfigurationUpdateTask LowCpuThreshold(string lowCpuThreshold = null)
        {
            WithArguments("--low-cpu-threshold");
            if (!string.IsNullOrEmpty(lowCpuThreshold))
            {
                 WithArguments(lowCpuThreshold);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureAdvisorConfigurationUpdateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureAdvisorConfigurationUpdateTask Add(string add = null)
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
        public AzureAdvisorConfigurationUpdateTask ForceString(string forceString = null)
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
        public AzureAdvisorConfigurationUpdateTask Remove(string remove = null)
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
        public AzureAdvisorConfigurationUpdateTask Set(string set = null)
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
