
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Signalr
{
     public partial class AzureSignalrDeleteTask : ExternalProcessTaskBase<AzureSignalrDeleteTask>
     {
        
        /// <summary>
        /// Deletes a SignalR Service.
        /// </summary>
        public AzureSignalrDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az signalr delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
