
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorLogProfilesDeleteTask : ExternalProcessTaskBase<AzureMonitorLogProfilesDeleteTask>
     {
        
        /// <summary>
        /// Deletes the log profile.
        /// </summary>
        public AzureMonitorLogProfilesDeleteTask(string name = null)
        {
            WithArguments("az monitor log-profiles delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
