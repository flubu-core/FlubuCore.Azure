
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorLogAnalyticsTask : ExternalProcessTaskBase<AzureMonitorLogAnalyticsTask>
     {
        
        /// <summary>
        /// Commands for querying data in Log Analytics workspaces.
        /// </summary>
        public AzureMonitorLogAnalyticsTask()
        {
            WithArguments("az monitor log-analytics");
        }

        protected override string Description { get; set; }
        
     }
}
