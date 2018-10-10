
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorActivityLogAlertScopeRemoveTask : ExternalProcessTaskBase<AzureMonitorActivityLogAlertScopeRemoveTask>
     {
        
        /// <summary>
        /// Removes scopes from this activity log alert.
        /// </summary>
        public AzureMonitorActivityLogAlertScopeRemoveTask(string name = null ,  string resourceGroup = null ,  string scope = null)
        {
            WithArguments("az monitor activity-log alert scope remove");
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

WithArguments("--scope");
            if (!string.IsNullOrEmpty(scope))
            {
                 WithArguments(scope);
            }

        }

        protected override string Description { get; set; }
        
     }
}
