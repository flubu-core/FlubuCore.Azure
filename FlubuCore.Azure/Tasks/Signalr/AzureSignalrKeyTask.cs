
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Signalr
{
     public partial class AzureSignalrKeyTask : ExternalProcessTaskBase<AzureSignalrKeyTask>
     {
        
        /// <summary>
        /// Manage keys for Azure SignalR Service.
        /// </summary>
        public AzureSignalrKeyTask()
        {
            WithArguments("az signalr key");
        }

        protected override string Description { get; set; }
        
     }
}
