
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherConfigureTask : ExternalProcessTaskBase<AzureNetworkWatcherConfigureTask>
     {
        
        /// <summary>
        /// Configure the Network Watcher service for different regions.
        /// </summary>
        public AzureNetworkWatcherConfigureTask(string locations = null)
        {
            WithArguments("az network watcher configure");
WithArguments("--locations");
            if (!string.IsNullOrEmpty(locations))
            {
                 WithArguments(locations);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Enabled status of Network Watcher in the specified regions.
        /// </summary>
        public AzureNetworkWatcherConfigureTask Enabled(string enabled = null)
        {
            WithArguments("--enabled");
            if (!string.IsNullOrEmpty(enabled))
            {
                 WithArguments(enabled);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. Required when enabling new regions.
        /// </summary>
        public AzureNetworkWatcherConfigureTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkWatcherConfigureTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }
     }
}
