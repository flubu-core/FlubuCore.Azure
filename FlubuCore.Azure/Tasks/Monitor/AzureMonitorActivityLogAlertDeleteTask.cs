
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorActivityLogAlertDeleteTask : ExternalProcessTaskBase<AzureMonitorActivityLogAlertDeleteTask>
     {
        
        /// <summary>
        /// Delete an activity log alert.
        /// </summary>
        public AzureMonitorActivityLogAlertDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az monitor activity-log alert delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
