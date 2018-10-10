
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cosmosdb
{
     public partial class AzureCosmosdbFailoverPriorityChangeTask : ExternalProcessTaskBase<AzureCosmosdbFailoverPriorityChangeTask>
     {
        
        /// <summary>
        /// Changes the failover priority for the Azure Cosmos DB database account.
        /// </summary>
        public AzureCosmosdbFailoverPriorityChangeTask(string failoverPolicies = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az cosmosdb failover-priority-change");
WithArguments("--failover-policies");
            if (!string.IsNullOrEmpty(failoverPolicies))
            {
                 WithArguments(failoverPolicies);
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
        
     }
}
