
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherConnectionMonitorQueryTask : ExternalProcessTaskBase<AzureNetworkWatcherConnectionMonitorQueryTask>
     {
        
        /// <summary>
        /// Query a snapshot of the most recent connection state of a connection monitor.
        /// </summary>
        public AzureNetworkWatcherConnectionMonitorQueryTask(string location = null ,  string name = null)
        {
            WithArguments("az network watcher connection-monitor query");
WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
