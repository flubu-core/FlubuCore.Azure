
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageQueuePolicyCreateTask : ExternalProcessTaskBase<AzureStorageQueuePolicyCreateTask>
     {
        
        /// <summary>
        /// Create a stored access policy on the containing object.
        /// </summary>
        public AzureStorageQueuePolicyCreateTask(string name = null ,  string queueName = null)
        {
            WithArguments("az storage queue policy create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--queue-name");
            if (!string.IsNullOrEmpty(queueName))
            {
                 WithArguments(queueName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The mode in which to run the command. "login" mode will directly use your login credentials for the authentication. The legacy "key" mode will attempt to query for an account key if no authentication parameters for the account are provided. Environment variable: AZURE_STORAGE_AUTH_MODE.
        /// </summary>
        public AzureStorageQueuePolicyCreateTask AuthMode(string authMode = null)
        {
            WithArguments("--auth-mode");
            if (!string.IsNullOrEmpty(authMode))
            {
                 WithArguments(authMode);
            }

            return this;
        }

        /// <summary>
        /// Expiration UTC datetime in (Y-m-d'T'H:M:S'Z').
        /// </summary>
        public AzureStorageQueuePolicyCreateTask Expiry(string expiry = null)
        {
            WithArguments("--expiry");
            if (!string.IsNullOrEmpty(expiry))
            {
                 WithArguments(expiry);
            }

            return this;
        }

        /// <summary>
        /// Allowed values: (a)dd (p)rocess (r)ead (u)pdate. Can be combined.
        /// </summary>
        public AzureStorageQueuePolicyCreateTask Permissions(string permissions = null)
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
        public AzureStorageQueuePolicyCreateTask Start(string start = null)
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
        public AzureStorageQueuePolicyCreateTask AccountKey(string accountKey = null)
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
        public AzureStorageQueuePolicyCreateTask AccountName(string accountName = null)
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
        public AzureStorageQueuePolicyCreateTask ConnectionString(string connectionString = null)
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
        public AzureStorageQueuePolicyCreateTask SasToken(string sasToken = null)
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
