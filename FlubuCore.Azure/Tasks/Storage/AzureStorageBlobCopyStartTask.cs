
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageBlobCopyStartTask : ExternalProcessTaskBase<AzureStorageBlobCopyStartTask>
     {
        
        /// <summary>
        /// Copies a blob asynchronously.
        /// </summary>
        public AzureStorageBlobCopyStartTask(string destinationBlob = null ,  string destinationContainer = null)
        {
            WithArguments("az storage blob copy start");
WithArguments("--destination-blob");
            if (!string.IsNullOrEmpty(destinationBlob))
            {
                 WithArguments(destinationBlob);
            }

WithArguments("--destination-container");
            if (!string.IsNullOrEmpty(destinationContainer))
            {
                 WithArguments(destinationContainer);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The mode in which to run the command. "login" mode will directly use your login credentials for the authentication. The legacy "key" mode will attempt to query for an account key if no authentication parameters for the account are provided. Environment variable: AZURE_STORAGE_AUTH_MODE.
        /// </summary>
        public AzureStorageBlobCopyStartTask AuthMode(string authMode = null)
        {
            WithArguments("--auth-mode");
            if (!string.IsNullOrEmpty(authMode))
            {
                 WithArguments(authMode);
            }

            return this;
        }

        /// <summary>
        /// The lease ID specified for this header must match the lease ID of the destination blob. If the request does not include the lease ID or it is not valid, the operation fails with status code 412 (Precondition Failed).
        /// </summary>
        public AzureStorageBlobCopyStartTask DestinationLeaseId(string destinationLeaseId = null)
        {
            WithArguments("--destination-lease-id");
            if (!string.IsNullOrEmpty(destinationLeaseId))
            {
                 WithArguments(destinationLeaseId);
            }

            return this;
        }

        /// <summary>
        /// Metadata in space-separated key=value pairs. This overwrites any existing metadata.
        /// </summary>
        public AzureStorageBlobCopyStartTask Metadata(string metadata = null)
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
        public AzureStorageBlobCopyStartTask Timeout(string timeout = null)
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
        public AzureStorageBlobCopyStartTask SourceAccountKey(string sourceAccountKey = null)
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
        public AzureStorageBlobCopyStartTask SourceAccountName(string sourceAccountName = null)
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
        public AzureStorageBlobCopyStartTask SourceBlob(string sourceBlob = null)
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
        public AzureStorageBlobCopyStartTask SourceContainer(string sourceContainer = null)
        {
            WithArguments("--source-container");
            if (!string.IsNullOrEmpty(sourceContainer))
            {
                 WithArguments(sourceContainer);
            }

            return this;
        }

        /// <summary>
        /// Specify this to perform the Copy Blob operation only if the lease ID given matches the active lease ID of the source blob.
        /// </summary>
        public AzureStorageBlobCopyStartTask SourceLeaseId(string sourceLeaseId = null)
        {
            WithArguments("--source-lease-id");
            if (!string.IsNullOrEmpty(sourceLeaseId))
            {
                 WithArguments(sourceLeaseId);
            }

            return this;
        }

        /// <summary>
        /// The file path for the source storage account.
        /// </summary>
        public AzureStorageBlobCopyStartTask SourcePath(string sourcePath = null)
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
        public AzureStorageBlobCopyStartTask SourceSas(string sourceSas = null)
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
        public AzureStorageBlobCopyStartTask SourceShare(string sourceShare = null)
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
        public AzureStorageBlobCopyStartTask SourceSnapshot(string sourceSnapshot = null)
        {
            WithArguments("--source-snapshot");
            if (!string.IsNullOrEmpty(sourceSnapshot))
            {
                 WithArguments(sourceSnapshot);
            }

            return this;
        }

        /// <summary>
        /// A URL of up to 2 KB in length that specifies an Azure file or blob. The value should be URL-encoded as it would appear in a request URI. If the source is in another account, the source must either be public or must be authenticated via a shared access signature. If the source is public, no authentication is required. Examples: <a href="https://myaccount.blob.core.windows.net/mycontainer/myblob">https://myaccount.blob.core.windows.net/mycontainer/myblob</a> <a href="https://myaccount.blob.core.windows.net/mycontainer/myblob">https://myaccount.blob.core.windows.net/mycontainer/myblob</a>?snapshot=&lt;DateTime&gt; <a href="https://otheraccount.blob.core.windows.net/mycontainer/myblob?sastoken">https://otheraccount.blob.core.windows.net/mycontainer/myblob?sastoken</a>.
        /// </summary>
        public AzureStorageBlobCopyStartTask SourceUri(string sourceUri = null)
        {
            WithArguments("--source-uri");
            if (!string.IsNullOrEmpty(sourceUri))
            {
                 WithArguments(sourceUri);
            }

            return this;
        }

        /// <summary>
        /// An ETag value, or the wildcard character (*). Specify an ETag value for this conditional header to copy the blob only if the specified ETag value matches the ETag value for an existing destination blob. If the ETag for the destination blob does not match the ETag specified for If-Match, the Blob service returns status code 412 (Precondition Failed).
        /// </summary>
        public AzureStorageBlobCopyStartTask DestinationIfMatch(string destinationIfMatch = null)
        {
            WithArguments("--destination-if-match");
            if (!string.IsNullOrEmpty(destinationIfMatch))
            {
                 WithArguments(destinationIfMatch);
            }

            return this;
        }

        /// <summary>
        /// A DateTime value. Azure expects the date value passed in to be UTC. If timezone is included, any non-UTC datetimes will be converted to UTC. If a date is passed in without timezone info, it is assumed to be UTC. Specify this conditional header to copy the blob only if the destination blob has been modified since the specified date/time. If the destination blob has not been modified, the Blob service returns status code 412 (Precondition Failed).
        /// </summary>
        public AzureStorageBlobCopyStartTask DestinationIfModifiedSince(string destinationIfModifiedSince = null)
        {
            WithArguments("--destination-if-modified-since");
            if (!string.IsNullOrEmpty(destinationIfModifiedSince))
            {
                 WithArguments(destinationIfModifiedSince);
            }

            return this;
        }

        /// <summary>
        /// An ETag value, or the wildcard character (*). Specify an ETag value for this conditional header to copy the blob only if the specified ETag value does not match the ETag value for the destination blob. Specify the wildcard character (*) to perform the operation only if the destination blob does not exist. If the specified condition isn't met, the Blob service returns status code 412 (Precondition Failed).
        /// </summary>
        public AzureStorageBlobCopyStartTask DestinationIfNoneMatch(string destinationIfNoneMatch = null)
        {
            WithArguments("--destination-if-none-match");
            if (!string.IsNullOrEmpty(destinationIfNoneMatch))
            {
                 WithArguments(destinationIfNoneMatch);
            }

            return this;
        }

        /// <summary>
        /// A DateTime value. Azure expects the date value passed in to be UTC. If timezone is included, any non-UTC datetimes will be converted to UTC. If a date is passed in without timezone info, it is assumed to be UTC. Specify this conditional header to copy the blob only if the destination blob has not been modified since the specified date/time. If the destination blob has been modified, the Blob service returns status code 412 (Precondition Failed).
        /// </summary>
        public AzureStorageBlobCopyStartTask DestinationIfUnmodifiedSince(string destinationIfUnmodifiedSince = null)
        {
            WithArguments("--destination-if-unmodified-since");
            if (!string.IsNullOrEmpty(destinationIfUnmodifiedSince))
            {
                 WithArguments(destinationIfUnmodifiedSince);
            }

            return this;
        }

        /// <summary>
        /// An ETag value, or the wildcard character (*). Specify this conditional header to copy the source blob only if its ETag matches the value specified. If the ETag values do not match, the Blob service returns status code 412 (Precondition Failed). This header cannot be specified if the source is an Azure File.
        /// </summary>
        public AzureStorageBlobCopyStartTask SourceIfMatch(string sourceIfMatch = null)
        {
            WithArguments("--source-if-match");
            if (!string.IsNullOrEmpty(sourceIfMatch))
            {
                 WithArguments(sourceIfMatch);
            }

            return this;
        }

        /// <summary>
        /// A DateTime value. Azure expects the date value passed in to be UTC. If timezone is included, any non-UTC datetimes will be converted to UTC. If a date is passed in without timezone info, it is assumed to be UTC. Specify this conditional header to copy the blob only if the source blob has been modified since the specified date/time.
        /// </summary>
        public AzureStorageBlobCopyStartTask SourceIfModifiedSince(string sourceIfModifiedSince = null)
        {
            WithArguments("--source-if-modified-since");
            if (!string.IsNullOrEmpty(sourceIfModifiedSince))
            {
                 WithArguments(sourceIfModifiedSince);
            }

            return this;
        }

        /// <summary>
        /// An ETag value, or the wildcard character (*). Specify this conditional header to copy the blob only if its ETag does not match the value specified. If the values are identical, the Blob service returns status code 412 (Precondition Failed). This header cannot be specified if the source is an Azure File.
        /// </summary>
        public AzureStorageBlobCopyStartTask SourceIfNoneMatch(string sourceIfNoneMatch = null)
        {
            WithArguments("--source-if-none-match");
            if (!string.IsNullOrEmpty(sourceIfNoneMatch))
            {
                 WithArguments(sourceIfNoneMatch);
            }

            return this;
        }

        /// <summary>
        /// A DateTime value. Azure expects the date value passed in to be UTC. If timezone is included, any non-UTC datetimes will be converted to UTC. If a date is passed in without timezone info, it is assumed to be UTC. Specify this conditional header to copy the blob only if the source blob has not been modified since the specified date/time.
        /// </summary>
        public AzureStorageBlobCopyStartTask SourceIfUnmodifiedSince(string sourceIfUnmodifiedSince = null)
        {
            WithArguments("--source-if-unmodified-since");
            if (!string.IsNullOrEmpty(sourceIfUnmodifiedSince))
            {
                 WithArguments(sourceIfUnmodifiedSince);
            }

            return this;
        }

        /// <summary>
        /// Storage account key. Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_KEY.
        /// </summary>
        public AzureStorageBlobCopyStartTask AccountKey(string accountKey = null)
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
        public AzureStorageBlobCopyStartTask AccountName(string accountName = null)
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
        public AzureStorageBlobCopyStartTask ConnectionString(string connectionString = null)
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
        public AzureStorageBlobCopyStartTask SasToken(string sasToken = null)
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
