
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageTablePolicyCreateTask : ExternalProcessTaskBase<AzureStorageTablePolicyCreateTask>
     {
        
        /// <summary>
        /// Create a stored access policy on the containing object.
        /// </summary>
        public AzureStorageTablePolicyCreateTask(string name = null ,  string tableName = null)
        {
            WithArguments("az storage table policy create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--table-name");
            if (!string.IsNullOrEmpty(tableName))
            {
                 WithArguments(tableName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Expiration UTC datetime in (Y-m-d'T'H:M:S'Z').
        /// </summary>
        public AzureStorageTablePolicyCreateTask Expiry(string expiry = null)
        {
            WithArguments("--expiry");
            if (!string.IsNullOrEmpty(expiry))
            {
                 WithArguments(expiry);
            }

            return this;
        }

        /// <summary>
        /// Allowed values: (r)ead/query (a)dd (u)pdate (d)elete. Can be combined.
        /// </summary>
        public AzureStorageTablePolicyCreateTask Permissions(string permissions = null)
        {
            WithArguments("--permissions");
            if (!string.IsNullOrEmpty(permissions))
            {
                 WithArguments(permissions);
            }

            return this;
        }

        /// <summary>
        /// Start UTC datetime (Y-m-d'T'H:M:S'Z'). Defaults to time of request.
        /// </summary>
        public AzureStorageTablePolicyCreateTask Start(string start = null)
        {
            WithArguments("--start");
            if (!string.IsNullOrEmpty(start))
            {
                 WithArguments(start);
            }

            return this;
        }

        /// <summary>
        /// Storage account key. Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_KEY.
        /// </summary>
        public AzureStorageTablePolicyCreateTask AccountKey(string accountKey = null)
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
        public AzureStorageTablePolicyCreateTask AccountName(string accountName = null)
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
        public AzureStorageTablePolicyCreateTask ConnectionString(string connectionString = null)
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
        public AzureStorageTablePolicyCreateTask SasToken(string sasToken = null)
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
