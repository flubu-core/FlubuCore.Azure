
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbThreatPolicyUpdateTask : ExternalProcessTaskBase<AzureSqlDbThreatPolicyUpdateTask>
     {
        
        /// <summary>
        /// Update a database's threat detection policy.
        /// </summary>
        public AzureSqlDbThreatPolicyUpdateTask(string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql db threat-policy update");
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

WithArguments("--server");
            if (!string.IsNullOrEmpty(server))
            {
                 WithArguments(server);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Whether the alert is sent to the account administrators.
        /// </summary>
        public AzureSqlDbThreatPolicyUpdateTask EmailAccountAdmins(string emailAccountAdmins = null)
        {
            WithArguments("--email-account-admins");
            if (!string.IsNullOrEmpty(emailAccountAdmins))
            {
                 WithArguments(emailAccountAdmins);
            }

            return this;
        }

        /// <summary>
        /// List of email addresses that alerts are sent to.
        /// </summary>
        public AzureSqlDbThreatPolicyUpdateTask EmailAddresses(string emailAddresses = null)
        {
            WithArguments("--email-addresses");
            if (!string.IsNullOrEmpty(emailAddresses))
            {
                 WithArguments(emailAddresses);
            }

            return this;
        }

        /// <summary>
        /// List of disabled alerts.
        /// </summary>
        public AzureSqlDbThreatPolicyUpdateTask DisabledAlerts(string disabledAlerts = null)
        {
            WithArguments("--disabled-alerts");
            if (!string.IsNullOrEmpty(disabledAlerts))
            {
                 WithArguments(disabledAlerts);
            }

            return this;
        }

        /// <summary>
        /// The number of days to retain threat detection logs.
        /// </summary>
        public AzureSqlDbThreatPolicyUpdateTask RetentionDays(string retentionDays = null)
        {
            WithArguments("--retention-days");
            if (!string.IsNullOrEmpty(retentionDays))
            {
                 WithArguments(retentionDays);
            }

            return this;
        }

        /// <summary>
        /// Threat detection policy state.
        /// </summary>
        public AzureSqlDbThreatPolicyUpdateTask State(string state = null)
        {
            WithArguments("--state");
            if (!string.IsNullOrEmpty(state))
            {
                 WithArguments(state);
            }

            return this;
        }

        /// <summary>
        /// Name of the storage account.
        /// </summary>
        public AzureSqlDbThreatPolicyUpdateTask StorageAccount(string storageAccount = null)
        {
            WithArguments("--storage-account");
            if (!string.IsNullOrEmpty(storageAccount))
            {
                 WithArguments(storageAccount);
            }

            return this;
        }

        /// <summary>
        /// The storage account endpoint.
        /// </summary>
        public AzureSqlDbThreatPolicyUpdateTask StorageEndpoint(string storageEndpoint = null)
        {
            WithArguments("--storage-endpoint");
            if (!string.IsNullOrEmpty(storageEndpoint))
            {
                 WithArguments(storageEndpoint);
            }

            return this;
        }

        /// <summary>
        /// Access key for the storage account.
        /// </summary>
        public AzureSqlDbThreatPolicyUpdateTask StorageKey(string storageKey = null)
        {
            WithArguments("--storage-key");
            if (!string.IsNullOrEmpty(storageKey))
            {
                 WithArguments(storageKey);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureSqlDbThreatPolicyUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureSqlDbThreatPolicyUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureSqlDbThreatPolicyUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureSqlDbThreatPolicyUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
