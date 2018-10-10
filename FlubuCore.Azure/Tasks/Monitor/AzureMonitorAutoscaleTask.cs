
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAutoscaleTask : ExternalProcessTaskBase<AzureMonitorAutoscaleTask>
     {
        
        /// <summary>
        /// Manage autoscale settings.
        /// </summary>
        public AzureMonitorAutoscaleTask()
        {
            WithArguments("az monitor autoscale");
        }

        protected override string Description { get; set; }
        
     }
}
