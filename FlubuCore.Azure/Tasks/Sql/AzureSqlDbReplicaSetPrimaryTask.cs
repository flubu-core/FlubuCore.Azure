
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbReplicaSetPrimaryTask : ExternalProcessTaskBase<AzureSqlDbReplicaSetPrimaryTask>
     {
        
        /// <summary>
        /// Set the primary replica database by failing over from the current primary replica database.
        /// </summary>
        public AzureSqlDbReplicaSetPrimaryTask(string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql db replica set-primary");
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
        /// If specified, the failover operation will allow data loss.
        /// </summary>
        public AzureSqlDbReplicaSetPrimaryTask AllowDataLoss(string allowDataLoss = null)
        {
            WithArguments("--allow-data-loss");
            if (!string.IsNullOrEmpty(allowDataLoss))
            {
                 WithArguments(allowDataLoss);
            }

            return this;
        }
     }
}
