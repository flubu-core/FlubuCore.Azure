
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cosmosdb
{
     public partial class AzureCosmosdbRegenerateKeyTask : ExternalProcessTaskBase<AzureCosmosdbRegenerateKeyTask>
     {
        
        /// <summary>
        /// Regenerate an access key for a Azure Cosmos DB database account.
        /// </summary>
        public AzureCosmosdbRegenerateKeyTask(string keyKind = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az cosmosdb regenerate-key");
WithArguments("--key-kind");
            if (!string.IsNullOrEmpty(keyKind))
            {
                 WithArguments(keyKind);
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
