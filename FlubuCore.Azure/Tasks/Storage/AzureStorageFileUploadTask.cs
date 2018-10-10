
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageFileUploadTask : ExternalProcessTaskBase<AzureStorageFileUploadTask>
     {
        
        /// <summary>
        /// Upload a file to a share that uses the SMB 3.0 protocol.
        /// </summary>
        public AzureStorageFileUploadTask(string shareName = null ,  string source = null)
        {
            WithArguments("az storage file upload");
WithArguments("--share-name");
            if (!string.IsNullOrEmpty(shareName))
            {
                 WithArguments(shareName);
            }

WithArguments("--source");
            if (!string.IsNullOrEmpty(source))
            {
                 WithArguments(source);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The cache control string.
        /// </summary>
        public AzureStorageFileUploadTask ContentCacheControl(string contentCacheControl = null)
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
        public AzureStorageFileUploadTask ContentDisposition(string contentDisposition = null)
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
        public AzureStorageFileUploadTask ContentEncoding(string contentEncoding = null)
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
        public AzureStorageFileUploadTask ContentLanguage(string contentLanguage = null)
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
        public AzureStorageFileUploadTask ContentMd5(string contentMd5 = null)
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
        public AzureStorageFileUploadTask ContentType(string contentType = null)
        {
            WithArguments("--content-type");
            if (!string.IsNullOrEmpty(contentType))
            {
                 WithArguments(contentType);
            }

            return this;
        }

        /// <summary>
        /// Maximum number of parallel connections to use.
        /// </summary>
        public AzureStorageFileUploadTask MaxConnections(string maxConnections = null)
        {
            WithArguments("--max-connections");
            if (!string.IsNullOrEmpty(maxConnections))
            {
                 WithArguments(maxConnections);
            }

            return this;
        }

        /// <summary>
        /// Metadata in space-separated key=value pairs. This overwrites any existing metadata.
        /// </summary>
        public AzureStorageFileUploadTask Metadata(string metadata = null)
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
        public AzureStorageFileUploadTask NoProgress(string noProgress = null)
        {
            WithArguments("--no-progress");
            if (!string.IsNullOrEmpty(noProgress))
            {
                 WithArguments(noProgress);
            }

            return this;
        }

        /// <summary>
        /// The path to the file within the file share. If the file name is omitted, the source file name will be used.
        /// </summary>
        public AzureStorageFileUploadTask Path(string path = null)
        {
            WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

            return this;
        }

        /// <summary>
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageFileUploadTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// If true, calculates an MD5 hash for each range of the file. The storage service checks the hash of the content that has arrived with the hash that was sent. This is primarily valuable for detecting bitflips on the wire if using http instead of https as https (the default) will already validate. Note that this MD5 hash is not stored with the file.
        /// </summary>
        public AzureStorageFileUploadTask ValidateContent(string validateContent = null)
        {
            WithArguments("--validate-content");
            if (!string.IsNullOrEmpty(validateContent))
            {
                 WithArguments(validateContent);
            }

            return this;
        }

        /// <summary>
        /// Storage account key. Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_KEY.
        /// </summary>
        public AzureStorageFileUploadTask AccountKey(string accountKey = null)
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
        public AzureStorageFileUploadTask AccountName(string accountName = null)
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
        public AzureStorageFileUploadTask ConnectionString(string connectionString = null)
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
        public AzureStorageFileUploadTask SasToken(string sasToken = null)
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
