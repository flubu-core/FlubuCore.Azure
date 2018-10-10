
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorActionGroupTask : ExternalProcessTaskBase<AzureMonitorActionGroupTask>
     {
        
        /// <summary>
        /// Manage action groups.
        /// </summary>
        public AzureMonitorActionGroupTask()
        {
            WithArguments("az monitor action-group");
        }

        protected override string Description { get; set; }
        
     }
}
