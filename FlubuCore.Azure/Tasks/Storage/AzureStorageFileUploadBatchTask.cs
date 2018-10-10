
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageFileUploadBatchTask : ExternalProcessTaskBase<AzureStorageFileUploadBatchTask>
     {
        
        /// <summary>
        /// Upload files from a local directory to an Azure Storage File Share in a batch operation.
        /// </summary>
        public AzureStorageFileUploadBatchTask(string destination = null ,  string source = null)
        {
            WithArguments("az storage file upload-batch");
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
        /// The directory where the source data is copied to. If omitted, data is copied to the root directory.
        /// </summary>
        public AzureStorageFileUploadBatchTask DestinationPath(string destinationPath = null)
        {
            WithArguments("--destination-path");
            if (!string.IsNullOrEmpty(destinationPath))
            {
                 WithArguments(destinationPath);
            }

            return this;
        }

        /// <summary>
        /// List the files and blobs to be uploaded. No actual data transfer will occur.
        /// </summary>
        public AzureStorageFileUploadBatchTask Dryrun(string dryrun = null)
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
        public AzureStorageFileUploadBatchTask Metadata(string metadata = null)
        {
            WithArguments("--metadata");
            if (!string.IsNullOrEmpty(metadata))
            {
                 WithArguments(metadata);
            }

            return this;
        }

        /// <summary>
        /// Include this flag to disable progress reporting for the command.
        /// </summary>
        public AzureStorageFileUploadBatchTask NoProgress(string noProgress = null)
        {
            WithArguments("--no-progress");
            if (!string.IsNullOrEmpty(noProgress))
            {
                 WithArguments(noProgress);
            }

            return this;
        }

        /// <summary>
        /// The pattern used for file globbing. The supported patterns are '*', '?', '[seq', and '[!seq]'.
        /// </summary>
        public AzureStorageFileUploadBatchTask Pattern(string pattern = null)
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
        public AzureStorageFileUploadBatchTask ValidateContent(string validateContent = null)
        {
            WithArguments("--validate-content");
            if (!string.IsNullOrEmpty(validateContent))
            {
                 WithArguments(validateContent);
            }

            return this;
        }

        /// <summary>
        /// The cache control string.
        /// </summary>
        public AzureStorageFileUploadBatchTask ContentCacheControl(string contentCacheControl = null)
        {
            WithArguments("--content-cache-control");
            if (!string.IsNullOrEmpty(contentCacheControl))
            {
                 WithArguments(contentCacheControl);
            }

            return this;
        }

        /// <summary>
        /// Conveys additional information about how to process the response payload, and can also be used to attach additional metadata.
        /// </summary>
        public AzureStorageFileUploadBatchTask ContentDisposition(string contentDisposition = null)
        {
            WithArguments("--content-disposition");
            if (!string.IsNullOrEmpty(contentDisposition))
            {
                 WithArguments(contentDisposition);
            }

            return this;
        }

        /// <summary>
        /// The content encoding type.
        /// </summary>
        public AzureStorageFileUploadBatchTask ContentEncoding(string contentEncoding = null)
        {
            WithArguments("--content-encoding");
            if (!string.IsNullOrEmpty(contentEncoding))
            {
                 WithArguments(contentEncoding);
            }

            return this;
        }

        /// <summary>
        /// The content language.
        /// </summary>
        public AzureStorageFileUploadBatchTask ContentLanguage(string contentLanguage = null)
        {
            WithArguments("--content-language");
            if (!string.IsNullOrEmpty(contentLanguage))
            {
                 WithArguments(contentLanguage);
            }

            return this;
        }

        /// <summary>
        /// The content's MD5 hash.
        /// </summary>
        public AzureStorageFileUploadBatchTask ContentMd5(string contentMd5 = null)
        {
            WithArguments("--content-md5");
            if (!string.IsNullOrEmpty(contentMd5))
            {
                 WithArguments(contentMd5);
            }

            return this;
        }

        /// <summary>
        /// The content MIME type.
        /// </summary>
        public AzureStorageFileUploadBatchTask ContentType(string contentType = null)
        {
            WithArguments("--content-type");
            if (!string.IsNullOrEmpty(contentType))
            {
                 WithArguments(contentType);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of parallel connections to use. Default value is 1.
        /// </summary>
        public AzureStorageFileUploadBatchTask MaxConnections(string maxConnections = null)
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
        public AzureStorageFileUploadBatchTask AccountKey(string accountKey = null)
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
        public AzureStorageFileUploadBatchTask AccountName(string accountName = null)
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
        public AzureStorageFileUploadBatchTask ConnectionString(string connectionString = null)
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
        public AzureStorageFileUploadBatchTask SasToken(string sasToken = null)
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
