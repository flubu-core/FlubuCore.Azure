
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAutoscaleSettingsDeleteTask : ExternalProcessTaskBase<AzureMonitorAutoscaleSettingsDeleteTask>
     {
        
        /// <summary>
        /// Deletes and autoscale setting.
        /// </summary>
        public AzureMonitorAutoscaleSettingsDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az monitor autoscale-settings delete");
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
