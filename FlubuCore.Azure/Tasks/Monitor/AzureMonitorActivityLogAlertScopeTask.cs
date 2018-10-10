
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorActivityLogAlertScopeTask : ExternalProcessTaskBase<AzureMonitorActivityLogAlertScopeTask>
     {
        
        /// <summary>
        /// Manage scopes for activity log alerts.
        /// </summary>
        public AzureMonitorActivityLogAlertScopeTask()
        {
            WithArguments("az monitor activity-log alert scope");
        }

        protected override string Description { get; set; }
        
     }
}
