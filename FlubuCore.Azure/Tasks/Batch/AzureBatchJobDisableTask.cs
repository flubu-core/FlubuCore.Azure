
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchJobDisableTask : ExternalProcessTaskBase<AzureBatchJobDisableTask>
     {
        
        /// <summary>
        /// Disables the specified job, preventing new tasks from running.
        /// </summary>
        public AzureBatchJobDisableTask(string jobId = null)
        {
            WithArguments("az batch job disable");
WithArguments("--job-id");
            if (!string.IsNullOrEmpty(jobId))
            {
                 WithArguments(jobId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// What to do with active tasks associated with the job.
        /// </summary>
        public AzureBatchJobDisableTask DisableTasks(string disableTasks = null)
        {
            WithArguments("--disable-tasks");
            if (!string.IsNullOrEmpty(disableTasks))
            {
                 WithArguments(disableTasks);
            }

            return this;
        }

        /// <summary>
        /// Batch service endpoint. Alternatively, set by environment variable: AZURE_BATCH_ENDPOINT.
        /// </summary>
        public AzureBatchJobDisableTask AccountEndpoint(string accountEndpoint = null)
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
        public AzureBatchJobDisableTask AccountKey(string accountKey = null)
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
        public AzureBatchJobDisableTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// An ETag value associated with the version of the resource known to the client. The operation will be performed only if the resource's current ETag on the service exactly matches the value specified by the client.
        /// </summary>
        public AzureBatchJobDisableTask IfMatch(string ifMatch = null)
        {
            WithArguments("--if-match");
            if (!string.IsNullOrEmpty(ifMatch))
            {
                 WithArguments(ifMatch);
            }

            return this;
        }

        /// <summary>
        /// A timestamp indicating the last modified time of the resource known to the client. The operation will be performed only if the resource on the service has been modified since the specified time.
        /// </summary>
        public AzureBatchJobDisableTask IfModifiedSince(string ifModifiedSince = null)
        {
            WithArguments("--if-modified-since");
            if (!string.IsNullOrEmpty(ifModifiedSince))
            {
                 WithArguments(ifModifiedSince);
            }

            return this;
        }

        /// <summary>
        /// An ETag value associated with the version of the resource known to the client. The operation will be performed only if the resource's current ETag on the service does not match the value specified by the client.
        /// </summary>
        public AzureBatchJobDisableTask IfNoneMatch(string ifNoneMatch = null)
        {
            WithArguments("--if-none-match");
            if (!string.IsNullOrEmpty(ifNoneMatch))
            {
                 WithArguments(ifNoneMatch);
            }

            return this;
        }

        /// <summary>
        /// A timestamp indicating the last modified time of the resource known to the client. The operation will be performed only if the resource on the service has not been modified since the specified time.
        /// </summary>
        public AzureBatchJobDisableTask IfUnmodifiedSince(string ifUnmodifiedSince = null)
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
