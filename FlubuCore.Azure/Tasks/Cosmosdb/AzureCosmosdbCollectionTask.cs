
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cosmosdb
{
     public partial class AzureCosmosdbCollectionTask : ExternalProcessTaskBase<AzureCosmosdbCollectionTask>
     {
        
        /// <summary>
        /// Manage Azure Cosmos DB collections.
        /// </summary>
        public AzureCosmosdbCollectionTask()
        {
            WithArguments("az cosmosdb collection");
        }

        protected override string Description { get; set; }
        
     }
}
