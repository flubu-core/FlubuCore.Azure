
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageEntityInsertTask : ExternalProcessTaskBase<AzureStorageEntityInsertTask>
     {
        
        /// <summary>
        /// Insert an entity into a table.
        /// </summary>
        public AzureStorageEntityInsertTask(string entity = null ,  string tableName = null)
        {
            WithArguments("az storage entity insert");
WithArguments("--entity");
            if (!string.IsNullOrEmpty(entity))
            {
                 WithArguments(entity);
            }

WithArguments("--table-name");
            if (!string.IsNullOrEmpty(tableName))
            {
                 WithArguments(tableName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Behavior when an entity already exists for the specified PartitionKey and RowKey.
        /// </summary>
        public AzureStorageEntityInsertTask IfExists(string ifExists = null)
        {
            WithArguments("--if-exists");
            if (!string.IsNullOrEmpty(ifExists))
            {
                 WithArguments(ifExists);
            }

            return this;
        }

        /// <summary>
        /// The server timeout, expressed in seconds.
        /// </summary>
        public AzureStorageEntityInsertTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// Storage account key. Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_KEY.
        /// </summary>
        public AzureStorageEntityInsertTask AccountKey(string accountKey = null)
        {
            WithArguments("--account-key");
            if (!string.IsNullOrEmpty(accountKey))
            {
                 WithArguments(accountKey);
            }

            return this;
        }

        /// <summary>
        /// Storage account name. Related environment variable: AZURE_STORAGE_ACCOUNT. Must be used in conjunction with either storage account key or a SAS token. If neither are present, the command will try to query the storage account key using the authenticated Azure account. If a large number of storage commands are executed the API quota may be hit.
        /// </summary>
        public AzureStorageEntityInsertTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// Storage account connection string. Environment variable: AZURE_STORAGE_CONNECTION_STRING.
        /// </summary>
        public AzureStorageEntityInsertTask ConnectionString(string connectionString = null)
        {
            WithArguments("--connection-string");
            if (!string.IsNullOrEmpty(connectionString))
            {
                 WithArguments(connectionString);
            }

            return this;
        }

        /// <summary>
        /// A Shared Access Signature (SAS). Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_SAS_TOKEN.
        /// </summary>
        public AzureStorageEntityInsertTask SasToken(string sasToken = null)
        {
            WithArguments("--sas-token");
            if (!string.IsNullOrEmpty(sasToken))
            {
                 WithArguments(sasToken);
            }

            return this;
        }
     }
}
