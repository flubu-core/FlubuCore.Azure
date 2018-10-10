
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchJobResetTask : ExternalProcessTaskBase<AzureBatchJobResetTask>
     {
        
        /// <summary>
        /// Update the properties of a Batch job. Unspecified properties which can be updated are reset to their defaults.
        /// </summary>
        public AzureBatchJobResetTask(string jobId = null)
        {
            WithArguments("az batch job reset");
WithArguments("--job-id");
            if (!string.IsNullOrEmpty(jobId))
            {
                 WithArguments(jobId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// A file containing the job update parameter specification in JSON (formatted to match the respective REST API body). If this parameter is specified, all 'Job Arguments' are ignored.
        /// </summary>
        public AzureBatchJobResetTask JsonFile(string jsonFile = null)
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
        public AzureBatchJobResetTask AccountEndpoint(string accountEndpoint = null)
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
        public AzureBatchJobResetTask AccountKey(string accountKey = null)
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
        public AzureBatchJobResetTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// A list of name-value pairs associated with the job as metadata. If omitted, it takes the default value of an empty list; in effect, any existing metadata is deleted. Space-separated values in 'key=value' format.
        /// </summary>
        public AzureBatchJobResetTask Metadata(string metadata = null)
        {
            WithArguments("--metadata");
            if (!string.IsNullOrEmpty(metadata))
            {
                 WithArguments(metadata);
            }

            return this;
        }

        /// <summary>
        /// The action the Batch service should take when all tasks in the job are in the completed state. If omitted, the completion behavior is set to noaction. If the current value is terminatejob, this is an error because a job's completion behavior may not be changed from terminatejob to noaction. You may not change the value from terminatejob to noaction - that is, once you have engaged automatic job termination, you cannot turn it off again. If you try to do this, the request fails and Batch returns status code 400 (Bad Request) and an 'invalid property value' error response. If you do not specify this element in a PUT request, it is equivalent to passing noaction. This is an error if the current value is terminatejob.
        /// </summary>
        public AzureBatchJobResetTask OnAllTasksComplete(string onAllTasksComplete = null)
        {
            WithArguments("--on-all-tasks-complete");
            if (!string.IsNullOrEmpty(onAllTasksComplete))
            {
                 WithArguments(onAllTasksComplete);
            }

            return this;
        }

        /// <summary>
        /// The priority of the job. Priority values can range from -1000 to 1000, with -1000 being the lowest priority and 1000 being the highest priority. If omitted, it is set to the default value 0.
        /// </summary>
        public AzureBatchJobResetTask Priority(string priority = null)
        {
            WithArguments("--priority");
            if (!string.IsNullOrEmpty(priority))
            {
                 WithArguments(priority);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of times each task may be retried. The Batch service retries a task if its exit code is nonzero. Note that this value specifically controls the number of retries. The Batch service will try each task once, and may then retry up to this limit. For example, if the maximum retry count is 3, Batch tries a task up to 4 times (one initial try and 3 retries). If the maximum retry count is 0, the Batch service does not retry tasks. If the maximum retry count is -1, the Batch service retries tasks without limit. The default value is 0 (no retries).
        /// </summary>
        public AzureBatchJobResetTask JobMaxTaskRetryCount(string jobMaxTaskRetryCount = null)
        {
            WithArguments("--job-max-task-retry-count");
            if (!string.IsNullOrEmpty(jobMaxTaskRetryCount))
            {
                 WithArguments(jobMaxTaskRetryCount);
            }

            return this;
        }

        /// <summary>
        /// The maximum elapsed time that the job may run, measured from the time the job is created. If the job does not complete within the time limit, the Batch service terminates it and any tasks that are still running. In this case, the termination reason will be MaxWallClockTimeExpiry. If this property is not specified, there is no time limit on how long the job may run. Expected format is an ISO-8601 duration.
        /// </summary>
        public AzureBatchJobResetTask JobMaxWallClockTime(string jobMaxWallClockTime = null)
        {
            WithArguments("--job-max-wall-clock-time");
            if (!string.IsNullOrEmpty(jobMaxWallClockTime))
            {
                 WithArguments(jobMaxWallClockTime);
            }

            return this;
        }

        /// <summary>
        /// The id of an existing pool. All the tasks of the job will run on the specified pool.
        /// </summary>
        public AzureBatchJobResetTask PoolId(string poolId = null)
        {
            WithArguments("--pool-id");
            if (!string.IsNullOrEmpty(poolId))
            {
                 WithArguments(poolId);
            }

            return this;
        }

        /// <summary>
        /// An ETag value associated with the version of the resource known to the client. The operation will be performed only if the resource's current ETag on the service exactly matches the value specified by the client.
        /// </summary>
        public AzureBatchJobResetTask IfMatch(string ifMatch = null)
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
        public AzureBatchJobResetTask IfModifiedSince(string ifModifiedSince = null)
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
        public AzureBatchJobResetTask IfNoneMatch(string ifNoneMatch = null)
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
        public AzureBatchJobResetTask IfUnmodifiedSince(string ifUnmodifiedSince = null)
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
