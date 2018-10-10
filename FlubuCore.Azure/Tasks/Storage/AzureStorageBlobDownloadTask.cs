
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageBlobDownloadTask : ExternalProcessTaskBase<AzureStorageBlobDownloadTask>
     {
        
        /// <summary>
        /// Downloads a blob to a file path, with automatic chunking and progress notifications.
        /// </summary>
        public AzureStorageBlobDownloadTask(string containerName = null ,  string file = null ,  string name = null)
        {
            WithArguments("az storage blob download");
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
        public AzureStorageBlobDownloadTask AuthMode(string authMode = null)
        {
            WithArguments("--auth-mode");
            if (!string.IsNullOrEmpty(authMode))
            {
                 WithArguments(authMode);
            }

            return this;
        }

        /// <summary>
        /// End of byte range to use for downloading a section of the blob. If end_range is given, start_range must be provided. The start_range and end_range params are inclusive. Ex: start_range=0, end_range=511 will download first 512 bytes of blob.
        /// </summary>
        public AzureStorageBlobDownloadTask EndRange(string endRange = null)
        {
            WithArguments("--end-range");
            if (!string.IsNullOrEmpty(endRange))
            {
                 WithArguments(endRange);
            }

            return this;
        }

        /// <summary>
        /// Required if the blob has an active lease.
        /// </summary>
        public AzureStorageBlobDownloadTask LeaseId(string leaseId = null)
        {
            WithArguments("--lease-id");
            if (!string.IsNullOrEmpty(leaseId))
            {
                 WithArguments(leaseId);
            }

            return this;
        }

        /// <summary>
        /// If set to 2 or greater, an initial get will be done for the first self.MAX_SINGLE_GET_SIZE bytes of the blob. If this is the entire blob, the method returns at this point. If it is not, it will download the remaining data parallel using the number of threads equal to max_connections. Each chunk will be of size self.MAX_CHUNK_GET_SIZE. If set to 1, a single large get request will be done. This is not generally recommended but available if very few threads should be used, network requests are very expensive, or a non-seekable stream prevents parallel download. This may also be useful if many blobs are expected to be empty as an extra request is required for empty blobs if max_connections is greater than 1.
        /// </summary>
        public AzureStorageBlobDownloadTask MaxConnections(string maxConnections = null)
        {
            WithArguments("--max-connections");
            if (!string.IsNullOrEmpty(maxConnections))
            {
                 WithArguments(maxConnections);
            }

            return this;
        }

        /// <summary>
        /// Include this flag to disable progress reporting for the command.
        /// </summary>
        public AzureStorageBlobDownloadTask NoProgress(string noProgress = null)
        {
            WithArguments("--no-progress");
            if (!string.IsNullOrEmpty(noProgress))
            {
                 WithArguments(noProgress);
            }

            return this;
        }

        /// <summary>
        /// Mode to use when opening the file. Note that specifying append only open_mode prevents parallel download. So, max_connections must be set to 1 if this open_mode is used.
        /// </summary>
        public AzureStorageBlobDownloadTask OpenMode(string openMode = null)
        {
            WithArguments("--open-mode");
            if (!string.IsNullOrEmpty(openMode))
            {
                 WithArguments(openMode);
            }

            return this;
        }

        /// <summary>
        /// The snapshot parameter is an opaque DateTime value that, when present, specifies the blob snapshot to retrieve.
        /// </summary>
        public AzureStorageBlobDownloadTask Snapshot(string snapshot = null)
        {
            WithArguments("--snapshot");
            if (!string.IsNullOrEmpty(snapshot))
            {
                 WithArguments(snapshot);
            }

            return this;
        }

        /// <summary>
        /// The socket timeout(secs), used by the service to regulate data flow.
        /// </summary>
        public AzureStorageBlobDownloadTask SocketTimeout(string socketTimeout = null)
        {
            WithArguments("--socket-timeout");
            if (!string.IsNullOrEmpty(socketTimeout))
            {
                 WithArguments(socketTimeout);
            }

            return this;
        }

        /// <summary>
        /// Start of byte range to use for downloading a section of the blob. If no end_range is given, all bytes after the start_range will be downloaded. The start_range and end_range params are inclusive. Ex: start_range=0, end_range=511 will download first 512 bytes of blob.
        /// </summary>
        public AzureStorageBlobDownloadTask StartRange(string startRange = null)
        {
            WithArguments("--start-range");
            if (!string.IsNullOrEmpty(startRange))
            {
                 WithArguments(startRange);
            }

            return this;
        }

        /// <summary>
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageBlobDownloadTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// If set to true, validates an MD5 hash for each retrieved portion of the blob. This is primarily valuable for detecting bitflips on the wire if using http instead of https as https (the default) will already validate. Note that the service will only return transactional MD5s for chunks 4MB or less so the first get request will be of size self.MAX_CHUNK_GET_SIZE instead of self.MAX_SINGLE_GET_SIZE. If self.MAX_CHUNK_GET_SIZE was set to greater than 4MB an error will be thrown. As computing the MD5 takes processing time and more requests will need to be done due to the reduced chunk size there may be some increase in latency.
        /// </summary>
        public AzureStorageBlobDownloadTask ValidateContent(string validateContent = null)
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
        public AzureStorageBlobDownloadTask IfMatch(string ifMatch = null)
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
        public AzureStorageBlobDownloadTask IfModifiedSince(string ifModifiedSince = null)
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
        public AzureStorageBlobDownloadTask IfNoneMatch(string ifNoneMatch = null)
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
        public AzureStorageBlobDownloadTask IfUnmodifiedSince(string ifUnmodifiedSince = null)
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
        public AzureStorageBlobDownloadTask AccountKey(string accountKey = null)
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
        public AzureStorageBlobDownloadTask AccountName(string accountName = null)
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
        public AzureStorageBlobDownloadTask ConnectionString(string connectionString = null)
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
        public AzureStorageBlobDownloadTask SasToken(string sasToken = null)
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
