
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherTask : ExternalProcessTaskBase<AzureNetworkWatcherTask>
     {
        
        /// <summary>
        /// Manage the Azure Network Watcher.
        /// </summary>
        public AzureNetworkWatcherTask()
        {
            WithArguments("az network watcher");
        }

        protected override string Description { get; set; }
        
     }
}
