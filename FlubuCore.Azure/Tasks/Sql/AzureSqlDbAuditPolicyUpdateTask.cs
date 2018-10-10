
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbAuditPolicyUpdateTask : ExternalProcessTaskBase<AzureSqlDbAuditPolicyUpdateTask>
     {
        
        /// <summary>
        /// Update a database's auditing policy.
        /// </summary>
        public AzureSqlDbAuditPolicyUpdateTask(string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql db audit-policy update");
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
        /// List of actions and action groups to audit.
        /// </summary>
        public AzureSqlDbAuditPolicyUpdateTask Actions(string actions = null)
        {
            WithArguments("--actions");
            if (!string.IsNullOrEmpty(actions))
            {
                 WithArguments(actions);
            }

            return this;
        }

        /// <summary>
        /// The number of days to retain audit logs.
        /// </summary>
        public AzureSqlDbAuditPolicyUpdateTask RetentionDays(string retentionDays = null)
        {
            WithArguments("--retention-days");
            if (!string.IsNullOrEmpty(retentionDays))
            {
                 WithArguments(retentionDays);
            }

            return this;
        }

        /// <summary>
        /// Auditing policy state.
        /// </summary>
        public AzureSqlDbAuditPolicyUpdateTask State(string state = null)
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
        public AzureSqlDbAuditPolicyUpdateTask StorageAccount(string storageAccount = null)
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
        public AzureSqlDbAuditPolicyUpdateTask StorageEndpoint(string storageEndpoint = null)
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
        public AzureSqlDbAuditPolicyUpdateTask StorageKey(string storageKey = null)
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
        public AzureSqlDbAuditPolicyUpdateTask Add(string add = null)
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
        public AzureSqlDbAuditPolicyUpdateTask ForceString(string forceString = null)
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
        public AzureSqlDbAuditPolicyUpdateTask Remove(string remove = null)
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
        public AzureSqlDbAuditPolicyUpdateTask Set(string set = null)
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
