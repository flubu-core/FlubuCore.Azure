
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorActivityLogAlertTask : ExternalProcessTaskBase<AzureMonitorActivityLogAlertTask>
     {
        
        /// <summary>
        /// Manage activity log alerts.
        /// </summary>
        public AzureMonitorActivityLogAlertTask()
        {
            WithArguments("az monitor activity-log alert");
        }

        protected override string Description { get; set; }
        
     }
}
