
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorActivityLogAlertScopeAddTask : ExternalProcessTaskBase<AzureMonitorActivityLogAlertScopeAddTask>
     {
        
        /// <summary>
        /// Add scopes to this activity log alert.
        /// </summary>
        public AzureMonitorActivityLogAlertScopeAddTask(string name = null ,  string resourceGroup = null ,  string scope = null)
        {
            WithArguments("az monitor activity-log alert scope add");
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
        
        /// <summary>
        /// Remove all the existing scopes before add new scopes.
        /// </summary>
        public AzureMonitorActivityLogAlertScopeAddTask Reset(string reset = null)
        {
            WithArguments("--reset");
            if (!string.IsNullOrEmpty(reset))
            {
                 WithArguments(reset);
            }

            return this;
        }
     }
}
