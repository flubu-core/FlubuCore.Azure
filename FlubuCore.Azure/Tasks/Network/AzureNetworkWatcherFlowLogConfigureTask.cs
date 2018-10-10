
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherFlowLogConfigureTask : ExternalProcessTaskBase<AzureNetworkWatcherFlowLogConfigureTask>
     {
        
        /// <summary>
        /// Configure flow logging on a network security group.
        /// </summary>
        public AzureNetworkWatcherFlowLogConfigureTask(string nsg = null)
        {
            WithArguments("az network watcher flow-log configure");
WithArguments("--nsg");
            if (!string.IsNullOrEmpty(nsg))
            {
                 WithArguments(nsg);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Enable logging.
        /// </summary>
        public AzureNetworkWatcherFlowLogConfigureTask Enabled(string enabled = null)
        {
            WithArguments("--enabled");
            if (!string.IsNullOrEmpty(enabled))
            {
                 WithArguments(enabled);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureNetworkWatcherFlowLogConfigureTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Number of days to retain logs.
        /// </summary>
        public AzureNetworkWatcherFlowLogConfigureTask Retention(string retention = null)
        {
            WithArguments("--retention");
            if (!string.IsNullOrEmpty(retention))
            {
                 WithArguments(retention);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the storage account in which to save the flow logs.
        /// </summary>
        public AzureNetworkWatcherFlowLogConfigureTask StorageAccount(string storageAccount = null)
        {
            WithArguments("--storage-account");
            if (!string.IsNullOrEmpty(storageAccount))
            {
                 WithArguments(storageAccount);
            }

            return this;
        }
     }
}
