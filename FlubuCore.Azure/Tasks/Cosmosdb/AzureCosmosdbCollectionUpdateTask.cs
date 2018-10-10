
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cosmosdb
{
     public partial class AzureCosmosdbCollectionUpdateTask : ExternalProcessTaskBase<AzureCosmosdbCollectionUpdateTask>
     {
        
        /// <summary>
        /// Updates an Azure Cosmos DB collection.
        /// </summary>
        public AzureCosmosdbCollectionUpdateTask(string collectionName = null ,  string dbName = null)
        {
            WithArguments("az cosmosdb collection update");
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
        /// Default TTL.
        /// </summary>
        public AzureCosmosdbCollectionUpdateTask DefaultTtl(string defaultTtl = null)
        {
            WithArguments("--default-ttl");
            if (!string.IsNullOrEmpty(defaultTtl))
            {
                 WithArguments(defaultTtl);
            }

            return this;
        }

        /// <summary>
        /// Indexing Policy, you can enter it as a string or as a file, e.g., --indexing-policy @policy-file.json).
        /// </summary>
        public AzureCosmosdbCollectionUpdateTask IndexingPolicy(string indexingPolicy = null)
        {
            WithArguments("--indexing-policy");
            if (!string.IsNullOrEmpty(indexingPolicy))
            {
                 WithArguments(indexingPolicy);
            }

            return this;
        }

        /// <summary>
        /// Offer Throughput.
        /// </summary>
        public AzureCosmosdbCollectionUpdateTask Throughput(string throughput = null)
        {
            WithArguments("--throughput");
            if (!string.IsNullOrEmpty(throughput))
            {
                 WithArguments(throughput);
            }

            return this;
        }

        /// <summary>
        /// Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.
        /// </summary>
        public AzureCosmosdbCollectionUpdateTask Key(string key = null)
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
        public AzureCosmosdbCollectionUpdateTask Name(string name = null)
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
        public AzureCosmosdbCollectionUpdateTask ResourceGroupName(string resourceGroupName = null)
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
        public AzureCosmosdbCollectionUpdateTask UrlConnection(string urlConnection = null)
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
