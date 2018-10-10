
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlFailoverGroupCreateTask : ExternalProcessTaskBase<AzureSqlFailoverGroupCreateTask>
     {
        
        /// <summary>
        /// Creates a failover group.
        /// </summary>
        public AzureSqlFailoverGroupCreateTask(string name = null ,  string partnerServer = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql failover-group create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--partner-server");
            if (!string.IsNullOrEmpty(partnerServer))
            {
                 WithArguments(partnerServer);
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
        public AzureSqlFailoverGroupCreateTask AddDb(string addDb = null)
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
        public AzureSqlFailoverGroupCreateTask FailoverPolicy(string failoverPolicy = null)
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
        public AzureSqlFailoverGroupCreateTask GracePeriod(string gracePeriod = null)
        {
            WithArguments("--grace-period");
            if (!string.IsNullOrEmpty(gracePeriod))
            {
                 WithArguments(gracePeriod);
            }

            return this;
        }

        /// <summary>
        /// The name of the resource group of the partner server.
        /// </summary>
        public AzureSqlFailoverGroupCreateTask PartnerResourceGroup(string partnerResourceGroup = null)
        {
            WithArguments("--partner-resource-group");
            if (!string.IsNullOrEmpty(partnerResourceGroup))
            {
                 WithArguments(partnerResourceGroup);
            }

            return this;
        }
     }
}
