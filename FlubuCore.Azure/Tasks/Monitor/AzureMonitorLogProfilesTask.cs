
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorLogProfilesTask : ExternalProcessTaskBase<AzureMonitorLogProfilesTask>
     {
        
        /// <summary>
        /// Manage log profiles.
        /// </summary>
        public AzureMonitorLogProfilesTask()
        {
            WithArguments("az monitor log-profiles");
        }

        protected override string Description { get; set; }
        
     }
}
