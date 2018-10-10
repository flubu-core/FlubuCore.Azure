
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageFileCopyCancelTask : ExternalProcessTaskBase<AzureStorageFileCopyCancelTask>
     {
        
        /// <summary>
        /// Aborts a pending copy_file operation, and leaves a destination file  with zero length and full metadata.
        /// </summary>
        public AzureStorageFileCopyCancelTask(string copyId = null ,  string destinationPath = null ,  string destinationShare = null)
        {
            WithArguments("az storage file copy cancel");
WithArguments("--copy-id");
            if (!string.IsNullOrEmpty(copyId))
            {
                 WithArguments(copyId);
            }

WithArguments("--destination-path");
            if (!string.IsNullOrEmpty(destinationPath))
            {
                 WithArguments(destinationPath);
            }

WithArguments("--destination-share");
            if (!string.IsNullOrEmpty(destinationShare))
            {
                 WithArguments(destinationShare);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageFileCopyCancelTask Timeout(string timeout = null)
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
        public AzureStorageFileCopyCancelTask AccountKey(string accountKey = null)
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
        public AzureStorageFileCopyCancelTask AccountName(string accountName = null)
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
        public AzureStorageFileCopyCancelTask ConnectionString(string connectionString = null)
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
        public AzureStorageFileCopyCancelTask SasToken(string sasToken = null)
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
