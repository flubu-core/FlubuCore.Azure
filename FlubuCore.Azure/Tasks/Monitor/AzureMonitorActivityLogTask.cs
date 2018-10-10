
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorActivityLogTask : ExternalProcessTaskBase<AzureMonitorActivityLogTask>
     {
        
        /// <summary>
        /// Manage activity logs.
        /// </summary>
        public AzureMonitorActivityLogTask()
        {
            WithArguments("az monitor activity-log");
        }

        protected override string Description { get; set; }
        
     }
}
