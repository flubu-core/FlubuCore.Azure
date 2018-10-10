
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorMetricsAlertTask : ExternalProcessTaskBase<AzureMonitorMetricsAlertTask>
     {
        
        /// <summary>
        /// Manage near-realtime metric alert rules.
        /// </summary>
        public AzureMonitorMetricsAlertTask()
        {
            WithArguments("az monitor metrics alert");
        }

        protected override string Description { get; set; }
        
     }
}
