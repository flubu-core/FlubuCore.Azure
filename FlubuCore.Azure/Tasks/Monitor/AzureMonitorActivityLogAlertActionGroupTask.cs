
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorActivityLogAlertActionGroupTask : ExternalProcessTaskBase<AzureMonitorActivityLogAlertActionGroupTask>
     {
        
        /// <summary>
        /// Manage action groups for activity log alerts.
        /// </summary>
        public AzureMonitorActivityLogAlertActionGroupTask()
        {
            WithArguments("az monitor activity-log alert action-group");
        }

        protected override string Description { get; set; }
        
     }
}
