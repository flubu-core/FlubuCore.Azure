
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherPacketCaptureTask : ExternalProcessTaskBase<AzureNetworkWatcherPacketCaptureTask>
     {
        
        /// <summary>
        /// Manage packet capture sessions on VMs.
        /// </summary>
        public AzureNetworkWatcherPacketCaptureTask()
        {
            WithArguments("az network watcher packet-capture");
        }

        protected override string Description { get; set; }
        
     }
}
