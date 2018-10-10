
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAutoscaleRuleTask : ExternalProcessTaskBase<AzureMonitorAutoscaleRuleTask>
     {
        
        /// <summary>
        /// Manage autoscale scaling rules.
        /// </summary>
        public AzureMonitorAutoscaleRuleTask()
        {
            WithArguments("az monitor autoscale rule");
        }

        protected override string Description { get; set; }
        
     }
}
