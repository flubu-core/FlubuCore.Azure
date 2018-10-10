
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchPoolResizeTask : ExternalProcessTaskBase<AzureBatchPoolResizeTask>
     {
        
        /// <summary>
        /// Resize or stop resizing a Batch pool.
        /// </summary>
        public AzureBatchPoolResizeTask(string poolId = null)
        {
            WithArguments("az batch pool resize");
WithArguments("--pool-id");
            if (!string.IsNullOrEmpty(poolId))
            {
                 WithArguments(poolId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Stop the pool resize operation.
        /// </summary>
        public AzureBatchPoolResizeTask Abort(string abort = null)
        {
            WithArguments("--abort");
            if (!string.IsNullOrEmpty(abort))
            {
                 WithArguments(abort);
            }

            return this;
        }

        /// <summary>
        /// When nodes may be removed from the pool, if the pool size is decreasing.
        /// </summary>
        public AzureBatchPoolResizeTask NodeDeallocationOption(string nodeDeallocationOption = null)
        {
            WithArguments("--node-deallocation-option");
            if (!string.IsNullOrEmpty(nodeDeallocationOption))
            {
                 WithArguments(nodeDeallocationOption);
            }

            return this;
        }

        /// <summary>
        /// The timeout for allocation of compute nodes to the pool or removal of compute nodes from the pool. The default value is 15 minutes. The minimum value is 5 minutes. If you specify a value less than 5 minutes, the Batch service returns an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request).
        /// </summary>
        public AzureBatchPoolResizeTask ResizeTimeout(string resizeTimeout = null)
        {
            WithArguments("--resize-timeout");
            if (!string.IsNullOrEmpty(resizeTimeout))
            {
                 WithArguments(resizeTimeout);
            }

            return this;
        }

        /// <summary>
        /// The desired number of dedicated compute nodes in the pool.
        /// </summary>
        public AzureBatchPoolResizeTask TargetDedicatedNodes(string targetDedicatedNodes = null)
        {
            WithArguments("--target-dedicated-nodes");
            if (!string.IsNullOrEmpty(targetDedicatedNodes))
            {
                 WithArguments(targetDedicatedNodes);
            }

            return this;
        }

        /// <summary>
        /// The desired number of low-priority compute nodes in the pool.
        /// </summary>
        public AzureBatchPoolResizeTask TargetLowPriorityNodes(string targetLowPriorityNodes = null)
        {
            WithArguments("--target-low-priority-nodes");
            if (!string.IsNullOrEmpty(targetLowPriorityNodes))
            {
                 WithArguments(targetLowPriorityNodes);
            }

            return this;
        }

        /// <summary>
        /// Batch service endpoint. Alternatively, set by environment variable: AZURE_BATCH_ENDPOINT.
        /// </summary>
        public AzureBatchPoolResizeTask AccountEndpoint(string accountEndpoint = null)
        {
            WithArguments("--account-endpoint");
            if (!string.IsNullOrEmpty(accountEndpoint))
            {
                 WithArguments(accountEndpoint);
            }

            return this;
        }

        /// <summary>
        /// The Batch account key. Alternatively, set by environment variable: AZURE_BATCH_ACCESS_KEY.
        /// </summary>
        public AzureBatchPoolResizeTask AccountKey(string accountKey = null)
        {
            WithArguments("--account-key");
            if (!string.IsNullOrEmpty(accountKey))
            {
                 WithArguments(accountKey);
            }

            return this;
        }

        /// <summary>
        /// The Batch account name. Alternatively, set by environment variable: AZURE_BATCH_ACCOUNT.
        /// </summary>
        public AzureBatchPoolResizeTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// The operation will be performed only if the resource's current ETag exactly matches the specified value.
        /// </summary>
        public AzureBatchPoolResizeTask IfMatch(string ifMatch = null)
        {
            WithArguments("--if-match");
            if (!string.IsNullOrEmpty(ifMatch))
            {
                 WithArguments(ifMatch);
            }

            return this;
        }

        /// <summary>
        /// The operation will be performed only if the resource has been modified since the specified timestamp.
        /// </summary>
        public AzureBatchPoolResizeTask IfModifiedSince(string ifModifiedSince = null)
        {
            WithArguments("--if-modified-since");
            if (!string.IsNullOrEmpty(ifModifiedSince))
            {
                 WithArguments(ifModifiedSince);
            }

            return this;
        }

        /// <summary>
        /// The operation will not be performed only if the resource's current ETag exactly matches the specified value.
        /// </summary>
        public AzureBatchPoolResizeTask IfNoneMatch(string ifNoneMatch = null)
        {
            WithArguments("--if-none-match");
            if (!string.IsNullOrEmpty(ifNoneMatch))
            {
                 WithArguments(ifNoneMatch);
            }

            return this;
        }

        /// <summary>
        /// The operation will not be performed only if the resource has been modified since the specified timestamp.
        /// </summary>
        public AzureBatchPoolResizeTask IfUnmodifiedSince(string ifUnmodifiedSince = null)
        {
            WithArguments("--if-unmodified-since");
            if (!string.IsNullOrEmpty(ifUnmodifiedSince))
            {
                 WithArguments(ifUnmodifiedSince);
            }

            return this;
        }
     }
}
