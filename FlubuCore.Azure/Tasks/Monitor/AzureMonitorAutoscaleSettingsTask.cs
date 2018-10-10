
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAutoscaleSettingsTask : ExternalProcessTaskBase<AzureMonitorAutoscaleSettingsTask>
     {
        
        /// <summary>
        /// Manage autoscale settings.
        /// </summary>
        public AzureMonitorAutoscaleSettingsTask()
        {
            WithArguments("az monitor autoscale-settings");
        }

        protected override string Description { get; set; }
        
     }
}
