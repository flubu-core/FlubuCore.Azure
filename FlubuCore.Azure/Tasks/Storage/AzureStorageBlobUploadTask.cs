
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageBlobUploadTask : ExternalProcessTaskBase<AzureStorageBlobUploadTask>
     {
        
        /// <summary>
        /// Upload a file to a storage blob.
        /// </summary>
        public AzureStorageBlobUploadTask(string containerName = null ,  string file = null ,  string name = null)
        {
            WithArguments("az storage blob upload");
WithArguments("--container-name");
            if (!string.IsNullOrEmpty(containerName))
            {
                 WithArguments(containerName);
            }

WithArguments("--file");
            if (!string.IsNullOrEmpty(file))
            {
                 WithArguments(file);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The mode in which to run the command. "login" mode will directly use your login credentials for the authentication. The legacy "key" mode will attempt to query for an account key if no authentication parameters for the account are provided. Environment variable: AZURE_STORAGE_AUTH_MODE.
        /// </summary>
        public AzureStorageBlobUploadTask AuthMode(string authMode = null)
        {
            WithArguments("--auth-mode");
            if (!string.IsNullOrEmpty(authMode))
            {
                 WithArguments(authMode);
            }

            return this;
        }

        /// <summary>
        /// The cache control string.
        /// </summary>
        public AzureStorageBlobUploadTask ContentCacheControl(string contentCacheControl = null)
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
        public AzureStorageBlobUploadTask ContentDisposition(string contentDisposition = null)
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
        public AzureStorageBlobUploadTask ContentEncoding(string contentEncoding = null)
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
        public AzureStorageBlobUploadTask ContentLanguage(string contentLanguage = null)
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
        public AzureStorageBlobUploadTask ContentMd5(string contentMd5 = null)
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
        public AzureStorageBlobUploadTask ContentType(string contentType = null)
        {
            WithArguments("--content-type");
            if (!string.IsNullOrEmpty(contentType))
            {
                 WithArguments(contentType);
            }

            return this;
        }

        /// <summary>
        /// Required if the blob has an active lease.
        /// </summary>
        public AzureStorageBlobUploadTask LeaseId(string leaseId = null)
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
        public AzureStorageBlobUploadTask MaxConnections(string maxConnections = null)
        {
            WithArguments("--max-connections");
            if (!string.IsNullOrEmpty(maxConnections))
            {
                 WithArguments(maxConnections);
            }

            return this;
        }

        /// <summary>
        /// The max length in bytes permitted for an append blob.
        /// </summary>
        public AzureStorageBlobUploadTask MaxsizeCondition(string maxsizeCondition = null)
        {
            WithArguments("--maxsize-condition");
            if (!string.IsNullOrEmpty(maxsizeCondition))
            {
                 WithArguments(maxsizeCondition);
            }

            return this;
        }

        /// <summary>
        /// Metadata in space-separated key=value pairs. This overwrites any existing metadata.
        /// </summary>
        public AzureStorageBlobUploadTask Metadata(string metadata = null)
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
        public AzureStorageBlobUploadTask NoProgress(string noProgress = null)
        {
            WithArguments("--no-progress");
            if (!string.IsNullOrEmpty(noProgress))
            {
                 WithArguments(noProgress);
            }

            return this;
        }

        /// <summary>
        /// The socket timeout(secs), used by the service to regulate data flow.
        /// </summary>
        public AzureStorageBlobUploadTask SocketTimeout(string socketTimeout = null)
        {
            WithArguments("--socket-timeout");
            if (!string.IsNullOrEmpty(socketTimeout))
            {
                 WithArguments(socketTimeout);
            }

            return this;
        }

        /// <summary>
        /// A page blob tier value to set the blob to. The tier correlates to the size of the blob and number of allowed IOPS. This is only applicable to page blobs on premium storage accounts.
        /// </summary>
        public AzureStorageBlobUploadTask Tier(string tier = null)
        {
            WithArguments("--tier");
            if (!string.IsNullOrEmpty(tier))
            {
                 WithArguments(tier);
            }

            return this;
        }

        /// <summary>
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageBlobUploadTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// Defaults to 'page' for *.vhd files, or 'block' otherwise.
        /// </summary>
        public AzureStorageBlobUploadTask Type(string type = null)
        {
            WithArguments("--type");
            if (!string.IsNullOrEmpty(type))
            {
                 WithArguments(type);
            }

            return this;
        }

        /// <summary>
        /// Specifies that an MD5 hash shall be calculated for each chunk of the blob and verified by the service when the chunk has arrived.
        /// </summary>
        public AzureStorageBlobUploadTask ValidateContent(string validateContent = null)
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
        public AzureStorageBlobUploadTask IfMatch(string ifMatch = null)
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
        public AzureStorageBlobUploadTask IfModifiedSince(string ifModifiedSince = null)
        {
            WithArguments("--if-modified-since");
            if (!string.IsNullOrEmpty(ifModifiedSince))
            {
                 WithArguments(ifModifiedSince);
            }

            return this;
        }

        /// <summary>
        /// An ETag value, or the wildcard character (*). Specify this header to perform the operation only if the resource's ETag does not match the value specified. Specify the wildcard character (*) to perform the operation only if the resource does not exist, and fail the operation if it does exist.
        /// </summary>
        public AzureStorageBlobUploadTask IfNoneMatch(string ifNoneMatch = null)
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
        public AzureStorageBlobUploadTask IfUnmodifiedSince(string ifUnmodifiedSince = null)
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
        public AzureStorageBlobUploadTask AccountKey(string accountKey = null)
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
        public AzureStorageBlobUploadTask AccountName(string accountName = null)
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
        public AzureStorageBlobUploadTask ConnectionString(string connectionString = null)
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
        public AzureStorageBlobUploadTask SasToken(string sasToken = null)
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
