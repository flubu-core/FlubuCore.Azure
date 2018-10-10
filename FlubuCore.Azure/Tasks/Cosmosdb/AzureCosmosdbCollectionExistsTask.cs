
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cosmosdb
{
     public partial class AzureCosmosdbCollectionExistsTask : ExternalProcessTaskBase<AzureCosmosdbCollectionExistsTask>
     {
        
        /// <summary>
        /// Returns a boolean indicating whether the collection exists.
        /// </summary>
        public AzureCosmosdbCollectionExistsTask(string collectionName = null ,  string dbName = null)
        {
            WithArguments("az cosmosdb collection exists");
WithArguments("--collection-name");
            if (!string.IsNullOrEmpty(collectionName))
            {
                 WithArguments(collectionName);
            }

WithArguments("--db-name");
            if (!string.IsNullOrEmpty(dbName))
            {
                 WithArguments(dbName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.
        /// </summary>
        public AzureCosmosdbCollectionExistsTask Key(string key = null)
        {
            WithArguments("--key");
            if (!string.IsNullOrEmpty(key))
            {
                 WithArguments(key);
            }

            return this;
        }

        /// <summary>
        /// Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.
        /// </summary>
        public AzureCosmosdbCollectionExistsTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Name of the resource group. Must be used in conjunction with cosmosdb account name.
        /// </summary>
        public AzureCosmosdbCollectionExistsTask ResourceGroupName(string resourceGroupName = null)
        {
            WithArguments("--resource-group-name");
            if (!string.IsNullOrEmpty(resourceGroupName))
            {
                 WithArguments(resourceGroupName);
            }

            return this;
        }

        /// <summary>
        /// Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.
        /// </summary>
        public AzureCosmosdbCollectionExistsTask UrlConnection(string urlConnection = null)
        {
            WithArguments("--url-connection");
            if (!string.IsNullOrEmpty(urlConnection))
            {
                 WithArguments(urlConnection);
            }

            return this;
        }
     }
}
