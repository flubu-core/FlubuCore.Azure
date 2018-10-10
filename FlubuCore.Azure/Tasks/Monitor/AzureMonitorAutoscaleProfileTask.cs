
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAutoscaleProfileTask : ExternalProcessTaskBase<AzureMonitorAutoscaleProfileTask>
     {
        
        /// <summary>
        /// Manage autoscaling profiles.
        /// </summary>
        public AzureMonitorAutoscaleProfileTask()
        {
            WithArguments("az monitor autoscale profile");
        }

        protected override string Description { get; set; }
        
     }
}
