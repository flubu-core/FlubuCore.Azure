
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchNodeFileDownloadTask : ExternalProcessTaskBase<AzureBatchNodeFileDownloadTask>
     {
        
        /// <summary>
        /// Download the content of the a node file.
        /// </summary>
        public AzureBatchNodeFileDownloadTask(string destination = null ,  string filePath = null ,  string nodeId = null ,  string poolId = null)
        {
            WithArguments("az batch node file download");
WithArguments("--destination");
            if (!string.IsNullOrEmpty(destination))
            {
                 WithArguments(destination);
            }

WithArguments("--file-path");
            if (!string.IsNullOrEmpty(filePath))
            {
                 WithArguments(filePath);
            }

WithArguments("--node-id");
            if (!string.IsNullOrEmpty(nodeId))
            {
                 WithArguments(nodeId);
            }

WithArguments("--pool-id");
            if (!string.IsNullOrEmpty(poolId))
            {
                 WithArguments(poolId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Batch service endpoint. Alternatively, set by environment variable: AZURE_BATCH_ENDPOINT.
        /// </summary>
        public AzureBatchNodeFileDownloadTask AccountEndpoint(string accountEndpoint = null)
        {
            WithArguments("--account-endpoint");
            if (!string.IsNullOrEmpty(accountEndpoint))
            {
                 WithArguments(accountEndpoint);
            }

            return this;
        }

        /// <summary>
        /// Batch account key. Alternatively, set by environment variable: AZURE_BATCH_ACCESS_KEY.
        /// </summary>
        public AzureBatchNodeFileDownloadTask AccountKey(string accountKey = null)
        {
            WithArguments("--account-key");
            if (!string.IsNullOrEmpty(accountKey))
            {
                 WithArguments(accountKey);
            }

            return this;
        }

        /// <summary>
        /// Batch account name. Alternatively, set by environment variable: AZURE_BATCH_ACCOUNT.
        /// </summary>
        public AzureBatchNodeFileDownloadTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// The byte range to be retrieved. If not set the file will be retrieved to the end.
        /// </summary>
        public AzureBatchNodeFileDownloadTask EndRange(string endRange = null)
        {
            WithArguments("--end-range");
            if (!string.IsNullOrEmpty(endRange))
            {
                 WithArguments(endRange);
            }

            return this;
        }

        /// <summary>
        /// A timestamp indicating the last modified time of the resource known to the client. The operation will be performed only if the resource on the service has been modified since the specified time.
        /// </summary>
        public AzureBatchNodeFileDownloadTask IfModifiedSince(string ifModifiedSince = null)
        {
            WithArguments("--if-modified-since");
            if (!string.IsNullOrEmpty(ifModifiedSince))
            {
                 WithArguments(ifModifiedSince);
            }

            return this;
        }

        /// <summary>
        /// A timestamp indicating the last modified time of the resource known to the client. The operation will be performed only if the resource on the service has not been modified since the specified time.
        /// </summary>
        public AzureBatchNodeFileDownloadTask IfUnmodifiedSince(string ifUnmodifiedSince = null)
        {
            WithArguments("--if-unmodified-since");
            if (!string.IsNullOrEmpty(ifUnmodifiedSince))
            {
                 WithArguments(ifUnmodifiedSince);
            }

            return this;
        }

        /// <summary>
        /// The byte range to be retrieved. If not set the file will be retrieved from the beginning.
        /// </summary>
        public AzureBatchNodeFileDownloadTask StartRange(string startRange = null)
        {
            WithArguments("--start-range");
            if (!string.IsNullOrEmpty(startRange))
            {
                 WithArguments(startRange);
            }

            return this;
        }
     }
}
