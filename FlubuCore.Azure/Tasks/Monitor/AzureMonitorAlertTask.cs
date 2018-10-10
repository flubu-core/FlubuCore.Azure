
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAlertTask : ExternalProcessTaskBase<AzureMonitorAlertTask>
     {
        
        /// <summary>
        /// Manage metric-based alert rules.
        /// </summary>
        public AzureMonitorAlertTask()
        {
            WithArguments("az monitor alert");
        }

        protected override string Description { get; set; }
        
     }
}
