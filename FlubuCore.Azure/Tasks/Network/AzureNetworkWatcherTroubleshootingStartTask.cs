
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherTroubleshootingStartTask : ExternalProcessTaskBase<AzureNetworkWatcherTroubleshootingStartTask>
     {
        
        /// <summary>
        /// Troubleshoot issues with VPN connections or gateway connectivity.
        /// </summary>
        public AzureNetworkWatcherTroubleshootingStartTask(string resource = null ,  string storageAccount = null ,  string storagePath = null)
        {
            WithArguments("az network watcher troubleshooting start");
WithArguments("--resource");
            if (!string.IsNullOrEmpty(resource))
            {
                 WithArguments(resource);
            }

WithArguments("--storage-account");
            if (!string.IsNullOrEmpty(storageAccount))
            {
                 WithArguments(storageAccount);
            }

WithArguments("--storage-path");
            if (!string.IsNullOrEmpty(storagePath))
            {
                 WithArguments(storagePath);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkWatcherTroubleshootingStartTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureNetworkWatcherTroubleshootingStartTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// The type of target resource to troubleshoot, if resource ID is not specified.
        /// </summary>
        public AzureNetworkWatcherTroubleshootingStartTask ResourceType(string resourceType = null)
        {
            WithArguments("--resource-type");
            if (!string.IsNullOrEmpty(resourceType))
            {
                 WithArguments(resourceType);
            }

            return this;
        }
     }
}
