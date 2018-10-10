
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureCosmosdbTask : ExternalProcessTaskBase<AzureCosmosdbTask>
     {
        
        /// <summary>
        /// Manage Azure Cosmos DB database accounts.
        /// </summary>
        public AzureCosmosdbTask()
        {
            WithArguments("az cosmosdb");
        }

        protected override string Description { get; set; }
        
     }
}
