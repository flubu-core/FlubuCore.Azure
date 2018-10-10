
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorActivityLogAlertCreateTask : ExternalProcessTaskBase<AzureMonitorActivityLogAlertCreateTask>
     {
        
        /// <summary>
        /// Create a default activity log alert.
        /// </summary>
        public AzureMonitorActivityLogAlertCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az monitor activity-log alert create");
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
        /// Add an action group. Accepts space-separated action group identifiers. The identifier can be the action group's name or its resource ID.
        /// </summary>
        public AzureMonitorActivityLogAlertCreateTask ActionGroup(string actionGroup = null)
        {
            WithArguments("--action-group");
            if (!string.IsNullOrEmpty(actionGroup))
            {
                 WithArguments(actionGroup);
            }

            return this;
        }

        /// <summary>
        /// The condition that will cause the alert to activate. The format is FIELD=VALUE[ and FIELD=VALUE...].
        /// </summary>
        public AzureMonitorActivityLogAlertCreateTask Condition(string condition = null)
        {
            WithArguments("--condition");
            if (!string.IsNullOrEmpty(condition))
            {
                 WithArguments(condition);
            }

            return this;
        }

        /// <summary>
        /// Disable the activity log alert after it is created.
        /// </summary>
        public AzureMonitorActivityLogAlertCreateTask Disable(string disable = null)
        {
            WithArguments("--disable");
            if (!string.IsNullOrEmpty(disable))
            {
                 WithArguments(disable);
            }

            return this;
        }

        /// <summary>
        /// A list of strings that will be used as prefixes.
        /// </summary>
        public AzureMonitorActivityLogAlertCreateTask Scope(string scope = null)
        {
            WithArguments("--scope");
            if (!string.IsNullOrEmpty(scope))
            {
                 WithArguments(scope);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureMonitorActivityLogAlertCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Space-separated webhook properties in 'key[=value]' format. These properties are associated with the action groups added in this command.
        /// </summary>
        public AzureMonitorActivityLogAlertCreateTask WebhookProperties(string webhookProperties = null)
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
