
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cosmosdb
{
     public partial class AzureCosmosdbDatabaseExistsTask : ExternalProcessTaskBase<AzureCosmosdbDatabaseExistsTask>
     {
        
        /// <summary>
        /// Returns a boolean indicating whether the database exists.
        /// </summary>
        public AzureCosmosdbDatabaseExistsTask(string dbName = null)
        {
            WithArguments("az cosmosdb database exists");
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
        public AzureCosmosdbDatabaseExistsTask Key(string key = null)
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
        public AzureCosmosdbDatabaseExistsTask Name(string name = null)
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
        public AzureCosmosdbDatabaseExistsTask ResourceGroupName(string resourceGroupName = null)
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
        public AzureCosmosdbDatabaseExistsTask UrlConnection(string urlConnection = null)
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
