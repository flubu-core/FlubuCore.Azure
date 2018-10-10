
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAutoscaleProfileDeleteTask : ExternalProcessTaskBase<AzureMonitorAutoscaleProfileDeleteTask>
     {
        
        /// <summary>
        /// Delete an autoscale profile.
        /// </summary>
        public AzureMonitorAutoscaleProfileDeleteTask(string autoscaleName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az monitor autoscale profile delete");
WithArguments("--autoscale-name");
            if (!string.IsNullOrEmpty(autoscaleName))
            {
                 WithArguments(autoscaleName);
            }

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
