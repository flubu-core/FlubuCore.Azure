
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchTaskResetTask : ExternalProcessTaskBase<AzureBatchTaskResetTask>
     {
        
        /// <summary>
        /// Reset the properties of a Batch task.
        /// </summary>
        public AzureBatchTaskResetTask(string jobId = null ,  string taskId = null)
        {
            WithArguments("az batch task reset");
WithArguments("--job-id");
            if (!string.IsNullOrEmpty(jobId))
            {
                 WithArguments(jobId);
            }

WithArguments("--task-id");
            if (!string.IsNullOrEmpty(taskId))
            {
                 WithArguments(taskId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// A file containing the constraints specification in JSON (formatted to match the respective REST API body). If this parameter is specified, all 'Constraints Arguments' are ignored.
        /// </summary>
        public AzureBatchTaskResetTask JsonFile(string jsonFile = null)
        {
            WithArguments("--json-file");
            if (!string.IsNullOrEmpty(jsonFile))
            {
                 WithArguments(jsonFile);
            }

            return this;
        }

        /// <summary>
        /// Batch service endpoint. Alternatively, set by environment variable: AZURE_BATCH_ENDPOINT.
        /// </summary>
        public AzureBatchTaskResetTask AccountEndpoint(string accountEndpoint = null)
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
        public AzureBatchTaskResetTask AccountKey(string accountKey = null)
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
        public AzureBatchTaskResetTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of times the task may be retried. The Batch service retries a task if its exit code is nonzero. Note that this value specifically controls the number of retries for the task executable due to a nonzero exit code. The Batch service will try the task once, and may then retry up to this limit. For example, if the maximum retry count is 3, Batch tries the task up to 4 times (one initial try and 3 retries). If the maximum retry count is 0, the Batch service does not retry the task after the first attempt. If the maximum retry count is -1, the Batch service retries the task without limit. Resource files and application packages are only downloaded again if the task is retried on a new compute node.
        /// </summary>
        public AzureBatchTaskResetTask MaxTaskRetryCount(string maxTaskRetryCount = null)
        {
            WithArguments("--max-task-retry-count");
            if (!string.IsNullOrEmpty(maxTaskRetryCount))
            {
                 WithArguments(maxTaskRetryCount);
            }

            return this;
        }

        /// <summary>
        /// The maximum elapsed time that the task may run, measured from the time the task starts. If the task does not complete within the time limit, the Batch service terminates it. If this is not specified, there is no time limit on how long the task may run. Expected format is an ISO-8601 duration.
        /// </summary>
        public AzureBatchTaskResetTask MaxWallClockTime(string maxWallClockTime = null)
        {
            WithArguments("--max-wall-clock-time");
            if (!string.IsNullOrEmpty(maxWallClockTime))
            {
                 WithArguments(maxWallClockTime);
            }

            return this;
        }

        /// <summary>
        /// The minimum time to retain the task directory on the compute node where it ran, from the time it completes execution. After this time, the Batch service may delete the task directory and all its contents. The default is infinite, i.e. the task directory will be retained until the compute node is removed or reimaged. Expected format is an ISO-8601 duration.
        /// </summary>
        public AzureBatchTaskResetTask RetentionTime(string retentionTime = null)
        {
            WithArguments("--retention-time");
            if (!string.IsNullOrEmpty(retentionTime))
            {
                 WithArguments(retentionTime);
            }

            return this;
        }

        /// <summary>
        /// An ETag value associated with the version of the resource known to the client. The operation will be performed only if the resource's current ETag on the service exactly matches the value specified by the client.
        /// </summary>
        public AzureBatchTaskResetTask IfMatch(string ifMatch = null)
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
        public AzureBatchTaskResetTask IfModifiedSince(string ifModifiedSince = null)
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
        public AzureBatchTaskResetTask IfNoneMatch(string ifNoneMatch = null)
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
        public AzureBatchTaskResetTask IfUnmodifiedSince(string ifUnmodifiedSince = null)
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
