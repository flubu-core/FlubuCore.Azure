
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAutoscaleDeleteTask : ExternalProcessTaskBase<AzureMonitorAutoscaleDeleteTask>
     {
        
        /// <summary>
        /// Deletes and autoscale setting.
        /// </summary>
        public AzureMonitorAutoscaleDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az monitor autoscale delete");
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
