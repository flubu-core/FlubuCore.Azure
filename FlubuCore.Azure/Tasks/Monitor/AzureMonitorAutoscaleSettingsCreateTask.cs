
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAutoscaleSettingsCreateTask : ExternalProcessTaskBase<AzureMonitorAutoscaleSettingsCreateTask>
     {
        
        /// <summary>
        /// Creates or updates an autoscale setting.
        /// </summary>
        public AzureMonitorAutoscaleSettingsCreateTask(string name = null ,  string parameters = null ,  string resourceGroup = null)
        {
            WithArguments("az monitor autoscale-settings create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--parameters");
            if (!string.IsNullOrEmpty(parameters))
            {
                 WithArguments(parameters);
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
