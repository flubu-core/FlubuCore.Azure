
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorActionGroupDeleteTask : ExternalProcessTaskBase<AzureMonitorActionGroupDeleteTask>
     {
        
        /// <summary>
        /// Delete an action group.
        /// </summary>
        public AzureMonitorActionGroupDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az monitor action-group delete");
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
