
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageTableExistsTask : ExternalProcessTaskBase<AzureStorageTableExistsTask>
     {
        
        /// <summary>
        /// Returns a boolean indicating whether the table exists.
        /// </summary>
        public AzureStorageTableExistsTask(string name = null)
        {
            WithArguments("az storage table exists");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageTableExistsTask Timeout(string timeout = null)
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
        public AzureStorageTableExistsTask AccountKey(string accountKey = null)
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
        public AzureStorageTableExistsTask AccountName(string accountName = null)
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
        public AzureStorageTableExistsTask ConnectionString(string connectionString = null)
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
        public AzureStorageTableExistsTask SasToken(string sasToken = null)
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
