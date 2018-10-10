
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Cosmosdb;

namespace FlubuCore.Azure
{
    public class Cosmosdb
    {
        public AzureCosmosdbCheckNameExistsTask CosmosdbCheckNameExists(string name)
        {
            return new AzureCosmosdbCheckNameExistsTask(name);
        }

            public AzureCosmosdbCreateTask CosmosdbCreate(string name ,  string resourceGroup)
            {
                return new AzureCosmosdbCreateTask(name,  resourceGroup);
            }

            public AzureCosmosdbDeleteTask CosmosdbDelete(string name ,  string resourceGroup)
            {
                return new AzureCosmosdbDeleteTask(name,  resourceGroup);
            }

            public AzureCosmosdbFailoverPriorityChangeTask CosmosdbFailoverPriorityChange(string failoverPolicies ,  string name ,  string resourceGroup)
            {
                return new AzureCosmosdbFailoverPriorityChangeTask(failoverPolicies,  name,  resourceGroup);
            }

            public AzureCosmosdbRegenerateKeyTask CosmosdbRegenerateKey(string keyKind ,  string name ,  string resourceGroup)
            {
                return new AzureCosmosdbRegenerateKeyTask(keyKind,  name,  resourceGroup);
            }

            public AzureCosmosdbUpdateTask CosmosdbUpdate(string name ,  string resourceGroup)
            {
                return new AzureCosmosdbUpdateTask(name,  resourceGroup);
            }

            public AzureCosmosdbCollectionTask CosmosdbCollection()
            {
                return new AzureCosmosdbCollectionTask();
            }

            public AzureCosmosdbCollectionCreateTask CosmosdbCollectionCreate(string collectionName ,  string dbName)
            {
                return new AzureCosmosdbCollectionCreateTask(collectionName,  dbName);
            }

            public AzureCosmosdbCollectionDeleteTask CosmosdbCollectionDelete(string collectionName ,  string dbName)
            {
                return new AzureCosmosdbCollectionDeleteTask(collectionName,  dbName);
            }

            public AzureCosmosdbCollectionExistsTask CosmosdbCollectionExists(string collectionName ,  string dbName)
            {
                return new AzureCosmosdbCollectionExistsTask(collectionName,  dbName);
            }

            public AzureCosmosdbCollectionUpdateTask CosmosdbCollectionUpdate(string collectionName ,  string dbName)
            {
                return new AzureCosmosdbCollectionUpdateTask(collectionName,  dbName);
            }

            public AzureCosmosdbDatabaseTask CosmosdbDatabase()
            {
                return new AzureCosmosdbDatabaseTask();
            }

            public AzureCosmosdbDatabaseCreateTask CosmosdbDatabaseCreate(string dbName)
            {
                return new AzureCosmosdbDatabaseCreateTask(dbName);
            }

            public AzureCosmosdbDatabaseDeleteTask CosmosdbDatabaseDelete(string dbName)
            {
                return new AzureCosmosdbDatabaseDeleteTask(dbName);
            }

            public AzureCosmosdbDatabaseExistsTask CosmosdbDatabaseExists(string dbName)
            {
                return new AzureCosmosdbDatabaseExistsTask(dbName);
            }
        
    }
}

