
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorActivityLogAlertActionGroupRemoveTask : ExternalProcessTaskBase<AzureMonitorActivityLogAlertActionGroupRemoveTask>
     {
        
        /// <summary>
        /// Remove action groups from this activity log alert.
        /// </summary>
        public AzureMonitorActivityLogAlertActionGroupRemoveTask(string actionGroup = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az monitor activity-log alert action-group remove");
WithArguments("--action-group");
            if (!string.IsNullOrEmpty(actionGroup))
            {
                 WithArguments(actionGroup);
            }

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
