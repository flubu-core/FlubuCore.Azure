
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageBlobUploadBatchTask : ExternalProcessTaskBase<AzureStorageBlobUploadBatchTask>
     {
        
        /// <summary>
        /// Upload files from a local directory to a blob container.
        /// </summary>
        public AzureStorageBlobUploadBatchTask(string destination = null ,  string source = null)
        {
            WithArguments("az storage blob upload-batch");
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
        /// The mode in which to run the command. "login" mode will directly use your login credentials for the authentication. The legacy "key" mode will attempt to query for an account key if no authentication parameters for the account are provided. Environment variable: AZURE_STORAGE_AUTH_MODE.
        /// </summary>
        public AzureStorageBlobUploadBatchTask AuthMode(string authMode = null)
        {
            WithArguments("--auth-mode");
            if (!string.IsNullOrEmpty(authMode))
            {
                 WithArguments(authMode);
            }

            return this;
        }

        /// <summary>
        /// The destination path that will be appended to the blob name.
        /// </summary>
        public AzureStorageBlobUploadBatchTask DestinationPath(string destinationPath = null)
        {
            WithArguments("--destination-path");
            if (!string.IsNullOrEmpty(destinationPath))
            {
                 WithArguments(destinationPath);
            }

            return this;
        }

        /// <summary>
        /// Show the summary of the operations to be taken instead of actually uploading the file(s).
        /// </summary>
        public AzureStorageBlobUploadBatchTask Dryrun(string dryrun = null)
        {
            WithArguments("--dryrun");
            if (!string.IsNullOrEmpty(dryrun))
            {
                 WithArguments(dryrun);
            }

            return this;
        }

        /// <summary>
        /// Required if the blob has an active lease.
        /// </summary>
        public AzureStorageBlobUploadBatchTask LeaseId(string leaseId = null)
        {
            WithArguments("--lease-id");
            if (!string.IsNullOrEmpty(leaseId))
            {
                 WithArguments(leaseId);
            }

            return this;
        }

        /// <summary>
        /// Maximum number of parallel connections to use when the blob size exceeds 64MB.
        /// </summary>
        public AzureStorageBlobUploadBatchTask MaxConnections(string maxConnections = null)
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
        public AzureStorageBlobUploadBatchTask Metadata(string metadata = null)
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
        public AzureStorageBlobUploadBatchTask NoProgress(string noProgress = null)
        {
            WithArguments("--no-progress");
            if (!string.IsNullOrEmpty(noProgress))
            {
                 WithArguments(noProgress);
            }

            return this;
        }

        /// <summary>
        /// The pattern used for globbing files or blobs in the source. The supported patterns are '*', '?', '[seq]', and '[!seq]'.
        /// </summary>
        public AzureStorageBlobUploadBatchTask Pattern(string pattern = null)
        {
            WithArguments("--pattern");
            if (!string.IsNullOrEmpty(pattern))
            {
                 WithArguments(pattern);
            }

            return this;
        }

        /// <summary>
        /// The socket timeout(secs), used by the service to regulate data flow.
        /// </summary>
        public AzureStorageBlobUploadBatchTask SocketTimeout(string socketTimeout = null)
        {
            WithArguments("--socket-timeout");
            if (!string.IsNullOrEmpty(socketTimeout))
            {
                 WithArguments(socketTimeout);
            }

            return this;
        }

        /// <summary>
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageBlobUploadBatchTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// Defaults to 'page' for *.vhd files, or 'block' otherwise. The setting will override blob types for every file.
        /// </summary>
        public AzureStorageBlobUploadBatchTask Type(string type = null)
        {
            WithArguments("--type");
            if (!string.IsNullOrEmpty(type))
            {
                 WithArguments(type);
            }

            return this;
        }

        /// <summary>
        /// The cache control string.
        /// </summary>
        public AzureStorageBlobUploadBatchTask ContentCacheControl(string contentCacheControl = null)
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
        public AzureStorageBlobUploadBatchTask ContentDisposition(string contentDisposition = null)
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
        public AzureStorageBlobUploadBatchTask ContentEncoding(string contentEncoding = null)
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
        public AzureStorageBlobUploadBatchTask ContentLanguage(string contentLanguage = null)
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
        public AzureStorageBlobUploadBatchTask ContentMd5(string contentMd5 = null)
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
        public AzureStorageBlobUploadBatchTask ContentType(string contentType = null)
        {
            WithArguments("--content-type");
            if (!string.IsNullOrEmpty(contentType))
            {
                 WithArguments(contentType);
            }

            return this;
        }

        /// <summary>
        /// The max length in bytes permitted for an append blob.
        /// </summary>
        public AzureStorageBlobUploadBatchTask MaxsizeCondition(string maxsizeCondition = null)
        {
            WithArguments("--maxsize-condition");
            if (!string.IsNullOrEmpty(maxsizeCondition))
            {
                 WithArguments(maxsizeCondition);
            }

            return this;
        }

        /// <summary>
        /// Specifies that an MD5 hash shall be calculated for each chunk of the blob and verified by the service when the chunk has arrived.
        /// </summary>
        public AzureStorageBlobUploadBatchTask ValidateContent(string validateContent = null)
        {
            WithArguments("--validate-content");
            if (!string.IsNullOrEmpty(validateContent))
            {
                 WithArguments(validateContent);
            }

            return this;
        }

        /// <summary>
        /// An ETag value, or the wildcard character (*). Specify this header to perform the operation only if the resource's ETag matches the value specified.
        /// </summary>
        public AzureStorageBlobUploadBatchTask IfMatch(string ifMatch = null)
        {
            WithArguments("--if-match");
            if (!string.IsNullOrEmpty(ifMatch))
            {
                 WithArguments(ifMatch);
            }

            return this;
        }

        /// <summary>
        /// Commence only if modified since supplied UTC datetime (Y-m-d'T'H:M'Z').
        /// </summary>
        public AzureStorageBlobUploadBatchTask IfModifiedSince(string ifModifiedSince = null)
        {
            WithArguments("--if-modified-since");
            if (!string.IsNullOrEmpty(ifModifiedSince))
            {
                 WithArguments(ifModifiedSince);
            }

            return this;
        }

        /// <summary>
        /// An ETag value, or the wildcard character (*).
        /// </summary>
        public AzureStorageBlobUploadBatchTask IfNoneMatch(string ifNoneMatch = null)
        {
            WithArguments("--if-none-match");
            if (!string.IsNullOrEmpty(ifNoneMatch))
            {
                 WithArguments(ifNoneMatch);
            }

            return this;
        }

        /// <summary>
        /// Commence only if unmodified since supplied UTC datetime (Y-m-d'T'H:M'Z').
        /// </summary>
        public AzureStorageBlobUploadBatchTask IfUnmodifiedSince(string ifUnmodifiedSince = null)
        {
            WithArguments("--if-unmodified-since");
            if (!string.IsNullOrEmpty(ifUnmodifiedSince))
            {
                 WithArguments(ifUnmodifiedSince);
            }

            return this;
        }

        /// <summary>
        /// Storage account key. Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_KEY.
        /// </summary>
        public AzureStorageBlobUploadBatchTask AccountKey(string accountKey = null)
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
        public AzureStorageBlobUploadBatchTask AccountName(string accountName = null)
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
        public AzureStorageBlobUploadBatchTask ConnectionString(string connectionString = null)
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
        public AzureStorageBlobUploadBatchTask SasToken(string sasToken = null)
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
