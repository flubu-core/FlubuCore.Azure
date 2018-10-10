
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorMetricsTask : ExternalProcessTaskBase<AzureMonitorMetricsTask>
     {
        
        /// <summary>
        /// View Azure resource metrics.
        /// </summary>
        public AzureMonitorMetricsTask()
        {
            WithArguments("az monitor metrics");
        }

        protected override string Description { get; set; }
        
     }
}
