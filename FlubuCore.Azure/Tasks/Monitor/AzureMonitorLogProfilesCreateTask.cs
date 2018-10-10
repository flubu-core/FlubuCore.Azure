
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorLogProfilesCreateTask : ExternalProcessTaskBase<AzureMonitorLogProfilesCreateTask>
     {
        
        /// <summary>
        /// Create a log profile.
        /// </summary>
        public AzureMonitorLogProfilesCreateTask(string categories = null ,  string location = null ,  string locations = null ,  string name = null ,  string days = null ,  string enabled = null)
        {
            WithArguments("az monitor log-profiles create");
WithArguments("--categories");
            if (!string.IsNullOrEmpty(categories))
            {
                 WithArguments(categories);
            }

WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

WithArguments("--locations");
            if (!string.IsNullOrEmpty(locations))
            {
                 WithArguments(locations);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--days");
            if (!string.IsNullOrEmpty(days))
            {
                 WithArguments(days);
            }

WithArguments("--enabled");
            if (!string.IsNullOrEmpty(enabled))
            {
                 WithArguments(enabled);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The service bus rule ID of the service bus namespace in which you would like to have Event Hubs created for streaming the Activity Log. The rule ID is of the format '{service bus resource ID}/authorizationrules/{key name}'.
        /// </summary>
        public AzureMonitorLogProfilesCreateTask ServiceBusRuleId(string serviceBusRuleId = null)
        {
            WithArguments("--service-bus-rule-id");
            if (!string.IsNullOrEmpty(serviceBusRuleId))
            {
                 WithArguments(serviceBusRuleId);
            }

            return this;
        }

        /// <summary>
        /// The resource id of the storage account to which you would like to send the Activity Log.
        /// </summary>
        public AzureMonitorLogProfilesCreateTask StorageAccountId(string storageAccountId = null)
        {
            WithArguments("--storage-account-id");
            if (!string.IsNullOrEmpty(storageAccountId))
            {
                 WithArguments(storageAccountId);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureMonitorLogProfilesCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }
     }
}
