
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cosmosdb
{
     public partial class AzureCosmosdbCheckNameExistsTask : ExternalProcessTaskBase<AzureCosmosdbCheckNameExistsTask>
     {
        
        /// <summary>
        /// Checks if an Azure Cosmos DB account name exists.
        /// </summary>
        public AzureCosmosdbCheckNameExistsTask(string name = null)
        {
            WithArguments("az cosmosdb check-name-exists");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
