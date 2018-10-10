
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorActivityLogAlertActionGroupAddTask : ExternalProcessTaskBase<AzureMonitorActivityLogAlertActionGroupAddTask>
     {
        
        /// <summary>
        /// Add action groups to this activity log alert. It can also be used to overwrite existing webhook properties of particular action groups.
        /// </summary>
        public AzureMonitorActivityLogAlertActionGroupAddTask(string actionGroup = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az monitor activity-log alert action-group add");
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
        
        /// <summary>
        /// Remove all the existing action groups before add new conditions.
        /// </summary>
        public AzureMonitorActivityLogAlertActionGroupAddTask Reset(string reset = null)
        {
            WithArguments("--reset");
            if (!string.IsNullOrEmpty(reset))
            {
                 WithArguments(reset);
            }

            return this;
        }

        /// <summary>
        /// Fails the command if an action group to be added will change existing webhook properties.
        /// </summary>
        public AzureMonitorActivityLogAlertActionGroupAddTask Strict(string strict = null)
        {
            WithArguments("--strict");
            if (!string.IsNullOrEmpty(strict))
            {
                 WithArguments(strict);
            }

            return this;
        }

        /// <summary>
        /// Space-separated webhook properties in 'key[=value]' format. These properties will be associated with the action groups added in this command.
        /// </summary>
        public AzureMonitorActivityLogAlertActionGroupAddTask WebhookProperties(string webhookProperties = null)
        {
            WithArguments("--webhook-properties");
            if (!string.IsNullOrEmpty(webhookProperties))
            {
                 WithArguments(webhookProperties);
            }

            return this;
        }
     }
}
