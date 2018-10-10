
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlFailoverGroupUpdateTask : ExternalProcessTaskBase<AzureSqlFailoverGroupUpdateTask>
     {
        
        /// <summary>
        /// Updates the failover group.
        /// </summary>
        public AzureSqlFailoverGroupUpdateTask(string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql failover-group update");
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
        /// List of databases to add to Failover Group.
        /// </summary>
        public AzureSqlFailoverGroupUpdateTask AddDb(string addDb = null)
        {
            WithArguments("--add-db");
            if (!string.IsNullOrEmpty(addDb))
            {
                 WithArguments(addDb);
            }

            return this;
        }

        /// <summary>
        /// The failover policy of the Failover Group.
        /// </summary>
        public AzureSqlFailoverGroupUpdateTask FailoverPolicy(string failoverPolicy = null)
        {
            WithArguments("--failover-policy");
            if (!string.IsNullOrEmpty(failoverPolicy))
            {
                 WithArguments(failoverPolicy);
            }

            return this;
        }

        /// <summary>
        /// Interval in hours before automatic failover is initiated if an outage occurs on the primary server. This indicates that Azure SQL Database will not initiate automatic failover before the grace period expires. Please note that failover operation with AllowDataLoss option might cause data loss due to the nature of asynchronous synchronization.
        /// </summary>
        public AzureSqlFailoverGroupUpdateTask GracePeriod(string gracePeriod = null)
        {
            WithArguments("--grace-period");
            if (!string.IsNullOrEmpty(gracePeriod))
            {
                 WithArguments(gracePeriod);
            }

            return this;
        }

        /// <summary>
        /// List of databases to remove from Failover Group.
        /// </summary>
        public AzureSqlFailoverGroupUpdateTask RemoveDb(string removeDb = null)
        {
            WithArguments("--remove-db");
            if (!string.IsNullOrEmpty(removeDb))
            {
                 WithArguments(removeDb);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureSqlFailoverGroupUpdateTask Add(string add = null)
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
        public AzureSqlFailoverGroupUpdateTask ForceString(string forceString = null)
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
        public AzureSqlFailoverGroupUpdateTask Remove(string remove = null)
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
        public AzureSqlFailoverGroupUpdateTask Set(string set = null)
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
