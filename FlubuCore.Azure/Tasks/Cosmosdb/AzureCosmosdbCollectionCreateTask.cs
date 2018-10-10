
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cosmosdb
{
     public partial class AzureCosmosdbCollectionCreateTask : ExternalProcessTaskBase<AzureCosmosdbCollectionCreateTask>
     {
        
        /// <summary>
        /// Creates an Azure Cosmos DB collection.
        /// </summary>
        public AzureCosmosdbCollectionCreateTask(string collectionName = null ,  string dbName = null)
        {
            WithArguments("az cosmosdb collection create");
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
        public AzureCosmosdbCollectionCreateTask DefaultTtl(string defaultTtl = null)
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
        public AzureCosmosdbCollectionCreateTask IndexingPolicy(string indexingPolicy = null)
        {
            WithArguments("--indexing-policy");
            if (!string.IsNullOrEmpty(indexingPolicy))
            {
                 WithArguments(indexingPolicy);
            }

            return this;
        }

        /// <summary>
        /// Partition Key Path, e.g., '/properties/name'.
        /// </summary>
        public AzureCosmosdbCollectionCreateTask PartitionKeyPath(string partitionKeyPath = null)
        {
            WithArguments("--partition-key-path");
            if (!string.IsNullOrEmpty(partitionKeyPath))
            {
                 WithArguments(partitionKeyPath);
            }

            return this;
        }

        /// <summary>
        /// Offer Throughput.
        /// </summary>
        public AzureCosmosdbCollectionCreateTask Throughput(string throughput = null)
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
        public AzureCosmosdbCollectionCreateTask Key(string key = null)
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
        public AzureCosmosdbCollectionCreateTask Name(string name = null)
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
        public AzureCosmosdbCollectionCreateTask ResourceGroupName(string resourceGroupName = null)
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
        public AzureCosmosdbCollectionCreateTask UrlConnection(string urlConnection = null)
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
