
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageBlobCopyStartBatchTask : ExternalProcessTaskBase<AzureStorageBlobCopyStartBatchTask>
     {
        
        /// <summary>
        /// Copy multiple blobs or files to a blob container.
        /// </summary>
        public AzureStorageBlobCopyStartBatchTask()
        {
            WithArguments("az storage blob copy start-batch");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The mode in which to run the command. "login" mode will directly use your login credentials for the authentication. The legacy "key" mode will attempt to query for an account key if no authentication parameters for the account are provided. Environment variable: AZURE_STORAGE_AUTH_MODE.
        /// </summary>
        public AzureStorageBlobCopyStartBatchTask AuthMode(string authMode = null)
        {
            WithArguments("--auth-mode");
            if (!string.IsNullOrEmpty(authMode))
            {
                 WithArguments(authMode);
            }

            return this;
        }

        /// <summary>
        /// The blob container where the selected source files or blobs will be copied to.
        /// </summary>
        public AzureStorageBlobCopyStartBatchTask DestinationContainer(string destinationContainer = null)
        {
            WithArguments("--destination-container");
            if (!string.IsNullOrEmpty(destinationContainer))
            {
                 WithArguments(destinationContainer);
            }

            return this;
        }

        /// <summary>
        /// The destination path that will be appended to the blob name.
        /// </summary>
        public AzureStorageBlobCopyStartBatchTask DestinationPath(string destinationPath = null)
        {
            WithArguments("--destination-path");
            if (!string.IsNullOrEmpty(destinationPath))
            {
                 WithArguments(destinationPath);
            }

            return this;
        }

        /// <summary>
        /// List the files or blobs to be uploaded. No actual data transfer will occur.
        /// </summary>
        public AzureStorageBlobCopyStartBatchTask Dryrun(string dryrun = null)
        {
            WithArguments("--dryrun");
            if (!string.IsNullOrEmpty(dryrun))
            {
                 WithArguments(dryrun);
            }

            return this;
        }

        /// <summary>
        /// The pattern used for globbing files or blobs in the source. The supported patterns are '*', '?', '[seq', and '[!seq]'.
        /// </summary>
        public AzureStorageBlobCopyStartBatchTask Pattern(string pattern = null)
        {
            WithArguments("--pattern");
            if (!string.IsNullOrEmpty(pattern))
            {
                 WithArguments(pattern);
            }

            return this;
        }

        /// <summary>
        /// The account key for the source storage account.
        /// </summary>
        public AzureStorageBlobCopyStartBatchTask SourceAccountKey(string sourceAccountKey = null)
        {
            WithArguments("--source-account-key");
            if (!string.IsNullOrEmpty(sourceAccountKey))
            {
                 WithArguments(sourceAccountKey);
            }

            return this;
        }

        /// <summary>
        /// The source storage account from which the files or blobs are copied to the destination. If omitted, the source account is used.
        /// </summary>
        public AzureStorageBlobCopyStartBatchTask SourceAccountName(string sourceAccountName = null)
        {
            WithArguments("--source-account-name");
            if (!string.IsNullOrEmpty(sourceAccountName))
            {
                 WithArguments(sourceAccountName);
            }

            return this;
        }

        /// <summary>
        /// The source container from which blobs are copied.
        /// </summary>
        public AzureStorageBlobCopyStartBatchTask SourceContainer(string sourceContainer = null)
        {
            WithArguments("--source-container");
            if (!string.IsNullOrEmpty(sourceContainer))
            {
                 WithArguments(sourceContainer);
            }

            return this;
        }

        /// <summary>
        /// The shared access signature for the source storage account.
        /// </summary>
        public AzureStorageBlobCopyStartBatchTask SourceSas(string sourceSas = null)
        {
            WithArguments("--source-sas");
            if (!string.IsNullOrEmpty(sourceSas))
            {
                 WithArguments(sourceSas);
            }

            return this;
        }

        /// <summary>
        /// The source share from which files are copied.
        /// </summary>
        public AzureStorageBlobCopyStartBatchTask SourceShare(string sourceShare = null)
        {
            WithArguments("--source-share");
            if (!string.IsNullOrEmpty(sourceShare))
            {
                 WithArguments(sourceShare);
            }

            return this;
        }

        /// <summary>
        /// A URI specifying a file share or blob container from which the files or blobs are copied.
        /// </summary>
        public AzureStorageBlobCopyStartBatchTask SourceUri(string sourceUri = null)
        {
            WithArguments("--source-uri");
            if (!string.IsNullOrEmpty(sourceUri))
            {
                 WithArguments(sourceUri);
            }

            return this;
        }

        /// <summary>
        /// Storage account key. Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_KEY.
        /// </summary>
        public AzureStorageBlobCopyStartBatchTask AccountKey(string accountKey = null)
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
        public AzureStorageBlobCopyStartBatchTask AccountName(string accountName = null)
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
        public AzureStorageBlobCopyStartBatchTask ConnectionString(string connectionString = null)
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
        public AzureStorageBlobCopyStartBatchTask SasToken(string sasToken = null)
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
