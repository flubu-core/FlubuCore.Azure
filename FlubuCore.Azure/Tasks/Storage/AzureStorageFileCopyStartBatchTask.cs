
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageFileCopyStartBatchTask : ExternalProcessTaskBase<AzureStorageFileCopyStartBatchTask>
     {
        
        /// <summary>
        /// Copy multiple files or blobs to a file share.
        /// </summary>
        public AzureStorageFileCopyStartBatchTask()
        {
            WithArguments("az storage file copy start-batch");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The directory where the source data is copied to. If omitted, data is copied to the root directory.
        /// </summary>
        public AzureStorageFileCopyStartBatchTask DestinationPath(string destinationPath = null)
        {
            WithArguments("--destination-path");
            if (!string.IsNullOrEmpty(destinationPath))
            {
                 WithArguments(destinationPath);
            }

            return this;
        }

        /// <summary>
        /// The file share where the source data is copied to.
        /// </summary>
        public AzureStorageFileCopyStartBatchTask DestinationShare(string destinationShare = null)
        {
            WithArguments("--destination-share");
            if (!string.IsNullOrEmpty(destinationShare))
            {
                 WithArguments(destinationShare);
            }

            return this;
        }

        /// <summary>
        /// List the files and blobs to be copied. No actual data transfer will occur.
        /// </summary>
        public AzureStorageFileCopyStartBatchTask Dryrun(string dryrun = null)
        {
            WithArguments("--dryrun");
            if (!string.IsNullOrEmpty(dryrun))
            {
                 WithArguments(dryrun);
            }

            return this;
        }

        /// <summary>
        /// Metadata in space-separated key=value pairs. This overwrites any existing metadata.
        /// </summary>
        public AzureStorageFileCopyStartBatchTask Metadata(string metadata = null)
        {
            WithArguments("--metadata");
            if (!string.IsNullOrEmpty(metadata))
            {
                 WithArguments(metadata);
            }

            return this;
        }

        /// <summary>
        /// The pattern used for globbing files and blobs. The supported patterns are '*', '?', '[seq', and '[!seq]'.
        /// </summary>
        public AzureStorageFileCopyStartBatchTask Pattern(string pattern = null)
        {
            WithArguments("--pattern");
            if (!string.IsNullOrEmpty(pattern))
            {
                 WithArguments(pattern);
            }

            return this;
        }

        /// <summary>
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageFileCopyStartBatchTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// The account key for the source storage account. If omitted, the active login is used to determine the account key.
        /// </summary>
        public AzureStorageFileCopyStartBatchTask SourceAccountKey(string sourceAccountKey = null)
        {
            WithArguments("--source-account-key");
            if (!string.IsNullOrEmpty(sourceAccountKey))
            {
                 WithArguments(sourceAccountKey);
            }

            return this;
        }

        /// <summary>
        /// The source storage account to copy the data from. If omitted, the destination account is used.
        /// </summary>
        public AzureStorageFileCopyStartBatchTask SourceAccountName(string sourceAccountName = null)
        {
            WithArguments("--source-account-name");
            if (!string.IsNullOrEmpty(sourceAccountName))
            {
                 WithArguments(sourceAccountName);
            }

            return this;
        }

        /// <summary>
        /// The source container blobs are copied from.
        /// </summary>
        public AzureStorageFileCopyStartBatchTask SourceContainer(string sourceContainer = null)
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
        public AzureStorageFileCopyStartBatchTask SourceSas(string sourceSas = null)
        {
            WithArguments("--source-sas");
            if (!string.IsNullOrEmpty(sourceSas))
            {
                 WithArguments(sourceSas);
            }

            return this;
        }

        /// <summary>
        /// The source share files are copied from.
        /// </summary>
        public AzureStorageFileCopyStartBatchTask SourceShare(string sourceShare = null)
        {
            WithArguments("--source-share");
            if (!string.IsNullOrEmpty(sourceShare))
            {
                 WithArguments(sourceShare);
            }

            return this;
        }

        /// <summary>
        /// A URI that specifies a the source file share or blob container.
        /// </summary>
        public AzureStorageFileCopyStartBatchTask SourceUri(string sourceUri = null)
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
        public AzureStorageFileCopyStartBatchTask AccountKey(string accountKey = null)
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
        public AzureStorageFileCopyStartBatchTask AccountName(string accountName = null)
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
        public AzureStorageFileCopyStartBatchTask ConnectionString(string connectionString = null)
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
        public AzureStorageFileCopyStartBatchTask SasToken(string sasToken = null)
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
