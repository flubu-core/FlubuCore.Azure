
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cosmosdb
{
     public partial class AzureCosmosdbDatabaseTask : ExternalProcessTaskBase<AzureCosmosdbDatabaseTask>
     {
        
        /// <summary>
        /// Manage Azure Cosmos DB databases.
        /// </summary>
        public AzureCosmosdbDatabaseTask()
        {
            WithArguments("az cosmosdb database");
        }

        protected override string Description { get; set; }
        
     }
}
