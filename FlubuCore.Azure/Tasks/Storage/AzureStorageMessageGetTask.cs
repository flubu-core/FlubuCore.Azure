
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageMessageGetTask : ExternalProcessTaskBase<AzureStorageMessageGetTask>
     {
        
        /// <summary>
        /// Retrieves one or more messages from the front of the queue.
        /// </summary>
        public AzureStorageMessageGetTask(string queueName = null)
        {
            WithArguments("az storage message get");
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
        public AzureStorageMessageGetTask AuthMode(string authMode = null)
        {
            WithArguments("--auth-mode");
            if (!string.IsNullOrEmpty(authMode))
            {
                 WithArguments(authMode);
            }

            return this;
        }

        /// <summary>
        /// A nonzero integer value that specifies the number of messages to retrieve from the queue, up to a maximum of 32. If fewer are visible, the visible messages are returned. By default, a single message is retrieved from the queue with this operation.
        /// </summary>
        public AzureStorageMessageGetTask NumMessages(string numMessages = null)
        {
            WithArguments("--num-messages");
            if (!string.IsNullOrEmpty(numMessages))
            {
                 WithArguments(numMessages);
            }

            return this;
        }

        /// <summary>
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageMessageGetTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// Specifies the new visibility timeout value, in seconds, relative to server time. The new value must be larger than or equal to 1 second, and cannot be larger than 7 days. The visibility timeout of a message can be set to a value later than the expiry time.
        /// </summary>
        public AzureStorageMessageGetTask VisibilityTimeout(string visibilityTimeout = null)
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
        public AzureStorageMessageGetTask AccountKey(string accountKey = null)
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
        public AzureStorageMessageGetTask AccountName(string accountName = null)
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
        public AzureStorageMessageGetTask ConnectionString(string connectionString = null)
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
        public AzureStorageMessageGetTask SasToken(string sasToken = null)
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
