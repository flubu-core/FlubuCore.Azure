
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageFileDownloadBatchTask : ExternalProcessTaskBase<AzureStorageFileDownloadBatchTask>
     {
        
        /// <summary>
        /// Download files from an Azure Storage File Share to a local directory in a batch operation.
        /// </summary>
        public AzureStorageFileDownloadBatchTask(string destination = null ,  string source = null)
        {
            WithArguments("az storage file download-batch");
WithArguments("--destination");
            if (!string.IsNullOrEmpty(destination))
            {
                 WithArguments(destination);
            }

WithArguments("--source");
            if (!string.IsNullOrEmpty(source))
            {
                 WithArguments(source);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// List the files and blobs to be downloaded. No actual data transfer will occur.
        /// </summary>
        public AzureStorageFileDownloadBatchTask Dryrun(string dryrun = null)
        {
            WithArguments("--dryrun");
            if (!string.IsNullOrEmpty(dryrun))
            {
                 WithArguments(dryrun);
            }

            return this;
        }

        /// <summary>
        /// Include this flag to disable progress reporting for the command.
        /// </summary>
        public AzureStorageFileDownloadBatchTask NoProgress(string noProgress = null)
        {
            WithArguments("--no-progress");
            if (!string.IsNullOrEmpty(noProgress))
            {
                 WithArguments(noProgress);
            }

            return this;
        }

        /// <summary>
        /// The pattern used for file globbing. The supported patterns are '*', '?', '[seq]', and '[!seq]'.
        /// </summary>
        public AzureStorageFileDownloadBatchTask Pattern(string pattern = null)
        {
            WithArguments("--pattern");
            if (!string.IsNullOrEmpty(pattern))
            {
                 WithArguments(pattern);
            }

            return this;
        }

        /// <summary>
        /// If set, calculates an MD5 hash for each range of the file for validation.
        /// </summary>
        public AzureStorageFileDownloadBatchTask ValidateContent(string validateContent = null)
        {
            WithArguments("--validate-content");
            if (!string.IsNullOrEmpty(validateContent))
            {
                 WithArguments(validateContent);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of parallel connections to use. Default value is 1.
        /// </summary>
        public AzureStorageFileDownloadBatchTask MaxConnections(string maxConnections = null)
        {
            WithArguments("--max-connections");
            if (!string.IsNullOrEmpty(maxConnections))
            {
                 WithArguments(maxConnections);
            }

            return this;
        }

        /// <summary>
        /// Storage account key. Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_KEY.
        /// </summary>
        public AzureStorageFileDownloadBatchTask AccountKey(string accountKey = null)
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
        public AzureStorageFileDownloadBatchTask AccountName(string accountName = null)
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
        public AzureStorageFileDownloadBatchTask ConnectionString(string connectionString = null)
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
        public AzureStorageFileDownloadBatchTask SasToken(string sasToken = null)
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
