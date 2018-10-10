
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbReplicaDeleteLinkTask : ExternalProcessTaskBase<AzureSqlDbReplicaDeleteLinkTask>
     {
        
        /// <summary>
        /// Permanently stop data replication between two database replicas.
        /// </summary>
        public AzureSqlDbReplicaDeleteLinkTask(string name = null ,  string partnerServer = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql db replica delete-link");
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
        /// Name of the resource group that the other replica is in. If unspecified, defaults to the first database's resource group.
        /// </summary>
        public AzureSqlDbReplicaDeleteLinkTask PartnerResourceGroup(string partnerResourceGroup = null)
        {
            WithArguments("--partner-resource-group");
            if (!string.IsNullOrEmpty(partnerResourceGroup))
            {
                 WithArguments(partnerResourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Do not prompt for confirmation.
        /// </summary>
        public AzureSqlDbReplicaDeleteLinkTask Yes(string yes = null)
        {
            WithArguments("--yes");
            if (!string.IsNullOrEmpty(yes))
            {
                 WithArguments(yes);
            }

            return this;
        }
     }
}
