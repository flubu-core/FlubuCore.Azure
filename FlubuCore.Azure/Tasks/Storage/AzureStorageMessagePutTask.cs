
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageMessagePutTask : ExternalProcessTaskBase<AzureStorageMessagePutTask>
     {
        
        /// <summary>
        /// Adds a new message to the back of the message queue.
        /// </summary>
        public AzureStorageMessagePutTask(string content = null ,  string queueName = null)
        {
            WithArguments("az storage message put");
WithArguments("--content");
            if (!string.IsNullOrEmpty(content))
            {
                 WithArguments(content);
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
        public AzureStorageMessagePutTask AuthMode(string authMode = null)
        {
            WithArguments("--auth-mode");
            if (!string.IsNullOrEmpty(authMode))
            {
                 WithArguments(authMode);
            }

            return this;
        }

        /// <summary>
        /// Specifies the time-to-live interval for the message, in seconds. The time-to-live may be any positive number or -1 for infinity. If this parameter is omitted, the default time-to-live is 7 days.
        /// </summary>
        public AzureStorageMessagePutTask TimeToLive(string timeToLive = null)
        {
            WithArguments("--time-to-live");
            if (!string.IsNullOrEmpty(timeToLive))
            {
                 WithArguments(timeToLive);
            }

            return this;
        }

        /// <summary>
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageMessagePutTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// If not specified, the default value is 0. Specifies the new visibility timeout value, in seconds, relative to server time. The value must be larger than or equal to 0, and cannot be larger than 7 days. The visibility timeout of a message cannot be set to a value later than the expiry time. visibility_timeout should be set to a value smaller than the time-to-live value.
        /// </summary>
        public AzureStorageMessagePutTask VisibilityTimeout(string visibilityTimeout = null)
        {
            WithArguments("--visibility-timeout");
            if (!string.IsNullOrEmpty(visibilityTimeout))
            {
                 WithArguments(visibilityTimeout);
            }

            return this;
        }

        /// <summary>
        /// Storage account key. Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_KEY.
        /// </summary>
        public AzureStorageMessagePutTask AccountKey(string accountKey = null)
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
        public AzureStorageMessagePutTask AccountName(string accountName = null)
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
        public AzureStorageMessagePutTask ConnectionString(string connectionString = null)
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
        public AzureStorageMessagePutTask SasToken(string sasToken = null)
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
