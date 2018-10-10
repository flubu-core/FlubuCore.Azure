
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureSignalrTask : ExternalProcessTaskBase<AzureSignalrTask>
     {
        
        /// <summary>
        /// Manage Azure SignalR Service.
        /// </summary>
        public AzureSignalrTask()
        {
            WithArguments("az signalr");
        }

        protected override string Description { get; set; }
        
     }
}
