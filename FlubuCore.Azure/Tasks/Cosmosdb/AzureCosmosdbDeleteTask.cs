
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cosmosdb
{
     public partial class AzureCosmosdbDeleteTask : ExternalProcessTaskBase<AzureCosmosdbDeleteTask>
     {
        
        /// <summary>
        /// Deletes an Azure Cosmos DB database account.
        /// </summary>
        public AzureCosmosdbDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az cosmosdb delete");
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
