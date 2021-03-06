
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageEntityMergeTask : ExternalProcessTaskBase<AzureStorageEntityMergeTask>
     {
        
        /// <summary>
        /// Updates an existing entity by merging the entity's properties.
        /// </summary>
        public AzureStorageEntityMergeTask(string entity = null ,  string tableName = null)
        {
            WithArguments("az storage entity merge");
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
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageEntityMergeTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// The client may specify the ETag for the entity on the request in order to compare to the ETag maintained by the service for the purpose of optimistic concurrency. The merge operation will be performed only if the ETag sent by the client matches the value maintained by the server, indicating that the entity has not been modified since it was retrieved by the client. To force an unconditional merge, set If-Match to the wildcard character (*).
        /// </summary>
        public AzureStorageEntityMergeTask IfMatch(string ifMatch = null)
        {
            WithArguments("--if-match");
            if (!string.IsNullOrEmpty(ifMatch))
            {
                 WithArguments(ifMatch);
            }

            return this;
        }

        /// <summary>
        /// Storage account key. Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_KEY.
        /// </summary>
        public AzureStorageEntityMergeTask AccountKey(string accountKey = null)
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
        public AzureStorageEntityMergeTask AccountName(string accountName = null)
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
        public AzureStorageEntityMergeTask ConnectionString(string connectionString = null)
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
        public AzureStorageEntityMergeTask SasToken(string sasToken = null)
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
