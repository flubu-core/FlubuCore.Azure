
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageFileCopyStartTask : ExternalProcessTaskBase<AzureStorageFileCopyStartTask>
     {
        
        /// <summary>
        /// Copies a file asynchronously.
        /// </summary>
        public AzureStorageFileCopyStartTask(string destinationPath = null ,  string destinationShare = null)
        {
            WithArguments("az storage file copy start");
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
        /// Metadata in space-separated key=value pairs. This overwrites any existing metadata.
        /// </summary>
        public AzureStorageFileCopyStartTask Metadata(string metadata = null)
        {
            WithArguments("--metadata");
            if (!string.IsNullOrEmpty(metadata))
            {
                 WithArguments(metadata);
            }

            return this;
        }

        /// <summary>
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageFileCopyStartTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// The storage account key of the source blob.
        /// </summary>
        public AzureStorageFileCopyStartTask SourceAccountKey(string sourceAccountKey = null)
        {
            WithArguments("--source-account-key");
            if (!string.IsNullOrEmpty(sourceAccountKey))
            {
                 WithArguments(sourceAccountKey);
            }

            return this;
        }

        /// <summary>
        /// The storage account name of the source blob.
        /// </summary>
        public AzureStorageFileCopyStartTask SourceAccountName(string sourceAccountName = null)
        {
            WithArguments("--source-account-name");
            if (!string.IsNullOrEmpty(sourceAccountName))
            {
                 WithArguments(sourceAccountName);
            }

            return this;
        }

        /// <summary>
        /// The blob name for the source storage account.
        /// </summary>
        public AzureStorageFileCopyStartTask SourceBlob(string sourceBlob = null)
        {
            WithArguments("--source-blob");
            if (!string.IsNullOrEmpty(sourceBlob))
            {
                 WithArguments(sourceBlob);
            }

            return this;
        }

        /// <summary>
        /// The container name for the source storage account.
        /// </summary>
        public AzureStorageFileCopyStartTask SourceContainer(string sourceContainer = null)
        {
            WithArguments("--source-container");
            if (!string.IsNullOrEmpty(sourceContainer))
            {
                 WithArguments(sourceContainer);
            }

            return this;
        }

        /// <summary>
        /// The file path for the source storage account.
        /// </summary>
        public AzureStorageFileCopyStartTask SourcePath(string sourcePath = null)
        {
            WithArguments("--source-path");
            if (!string.IsNullOrEmpty(sourcePath))
            {
                 WithArguments(sourcePath);
            }

            return this;
        }

        /// <summary>
        /// The shared access signature for the source storage account.
        /// </summary>
        public AzureStorageFileCopyStartTask SourceSas(string sourceSas = null)
        {
            WithArguments("--source-sas");
            if (!string.IsNullOrEmpty(sourceSas))
            {
                 WithArguments(sourceSas);
            }

            return this;
        }

        /// <summary>
        /// The share name for the source storage account.
        /// </summary>
        public AzureStorageFileCopyStartTask SourceShare(string sourceShare = null)
        {
            WithArguments("--source-share");
            if (!string.IsNullOrEmpty(sourceShare))
            {
                 WithArguments(sourceShare);
            }

            return this;
        }

        /// <summary>
        /// The blob snapshot for the source storage account.
        /// </summary>
        public AzureStorageFileCopyStartTask SourceSnapshot(string sourceSnapshot = null)
        {
            WithArguments("--source-snapshot");
            if (!string.IsNullOrEmpty(sourceSnapshot))
            {
                 WithArguments(sourceSnapshot);
            }

            return this;
        }

        /// <summary>
        /// A URL of up to 2 KB in length that specifies an Azure file or blob. The value should be URL-encoded as it would appear in a request URI. If the source is in another account, the source must either be public or must be authenticated via a shared access signature. If the source is public, no authentication is required. Examples: <a href="https://myaccount.file.core.windows.net/myshare/mydir/myfile">https://myaccount.file.core.windows.net/myshare/mydir/myfile</a> <a href="https://otheraccount.file.core.windows.net/myshare/mydir/myfile?sastoken">https://otheraccount.file.core.windows.net/myshare/mydir/myfile?sastoken</a>.
        /// </summary>
        public AzureStorageFileCopyStartTask SourceUri(string sourceUri = null)
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
        public AzureStorageFileCopyStartTask AccountKey(string accountKey = null)
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
        public AzureStorageFileCopyStartTask AccountName(string accountName = null)
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
        public AzureStorageFileCopyStartTask ConnectionString(string connectionString = null)
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
        public AzureStorageFileCopyStartTask SasToken(string sasToken = null)
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
