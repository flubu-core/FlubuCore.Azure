
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchJobCreateTask : ExternalProcessTaskBase<AzureBatchJobCreateTask>
     {
        
        /// <summary>
        /// Add a job to a Batch account.
        /// </summary>
        public AzureBatchJobCreateTask()
        {
            WithArguments("az batch job create");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// A file containing the job specification in JSON (formatted to match the respective REST API body). If this parameter is specified, all 'Job Arguments' are ignored.
        /// </summary>
        public AzureBatchJobCreateTask JsonFile(string jsonFile = null)
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
        public AzureBatchJobCreateTask AccountEndpoint(string accountEndpoint = null)
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
        public AzureBatchJobCreateTask AccountKey(string accountKey = null)
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
        public AzureBatchJobCreateTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// Required. A string that uniquely identifies the job within the account. The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two IDs within an account that differ only by case).
        /// </summary>
        public AzureBatchJobCreateTask Id(string id = null)
        {
            WithArguments("--id");
            if (!string.IsNullOrEmpty(id))
            {
                 WithArguments(id);
            }

            return this;
        }

        /// <summary>
        /// A list of name-value pairs associated with the job as metadata. The Batch service does not assign any meaning to metadata; it is solely for the use of user code. Space-separated values in 'key=value' format.
        /// </summary>
        public AzureBatchJobCreateTask Metadata(string metadata = null)
        {
            WithArguments("--metadata");
            if (!string.IsNullOrEmpty(metadata))
            {
                 WithArguments(metadata);
            }

            return this;
        }

        /// <summary>
        /// The priority of the job. Priority values can range from -1000 to 1000, with -1000 being the lowest priority and 1000 being the highest priority. The default value is 0.
        /// </summary>
        public AzureBatchJobCreateTask Priority(string priority = null)
        {
            WithArguments("--priority");
            if (!string.IsNullOrEmpty(priority))
            {
                 WithArguments(priority);
            }

            return this;
        }

        /// <summary>
        /// Whether tasks in the job can define dependencies on each other. The default is false. True if flag present.
        /// </summary>
        public AzureBatchJobCreateTask UsesTaskDependencies(string usesTaskDependencies = null)
        {
            WithArguments("--uses-task-dependencies");
            if (!string.IsNullOrEmpty(usesTaskDependencies))
            {
                 WithArguments(usesTaskDependencies);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of times each task may be retried. The Batch service retries a task if its exit code is nonzero. Note that this value specifically controls the number of retries. The Batch service will try each task once, and may then retry up to this limit. For example, if the maximum retry count is 3, Batch tries a task up to 4 times (one initial try and 3 retries). If the maximum retry count is 0, the Batch service does not retry tasks. If the maximum retry count is -1, the Batch service retries tasks without limit. The default value is 0 (no retries).
        /// </summary>
        public AzureBatchJobCreateTask JobMaxTaskRetryCount(string jobMaxTaskRetryCount = null)
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
        public AzureBatchJobCreateTask JobMaxWallClockTime(string jobMaxWallClockTime = null)
        {
            WithArguments("--job-max-wall-clock-time");
            if (!string.IsNullOrEmpty(jobMaxWallClockTime))
            {
                 WithArguments(jobMaxWallClockTime);
            }

            return this;
        }

        /// <summary>
        /// Required. The command line of the Job Manager task. The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. If the command line refers to file paths, it should use a relative path (relative to the task working directory), or use the Batch provided environment variable (<a href="https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables">https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables</a>).
        /// </summary>
        public AzureBatchJobCreateTask JobManagerTaskCommandLine(string jobManagerTaskCommandLine = null)
        {
            WithArguments("--job-manager-task-command-line");
            if (!string.IsNullOrEmpty(jobManagerTaskCommandLine))
            {
                 WithArguments(jobManagerTaskCommandLine);
            }

            return this;
        }

        /// <summary>
        /// A list of environment variable settings for the Job Manager task. Space-separated values in 'key=value' format.
        /// </summary>
        public AzureBatchJobCreateTask JobManagerTaskEnvironmentSettings(string jobManagerTaskEnvironmentSettings = null)
        {
            WithArguments("--job-manager-task-environment-settings");
            if (!string.IsNullOrEmpty(jobManagerTaskEnvironmentSettings))
            {
                 WithArguments(jobManagerTaskEnvironmentSettings);
            }

            return this;
        }

        /// <summary>
        /// Required. A string that uniquely identifies the Job Manager task within the job. The ID can contain any combination of alphanumeric characters including hyphens and underscores and cannot contain more than 64 characters.
        /// </summary>
        public AzureBatchJobCreateTask JobManagerTaskId(string jobManagerTaskId = null)
        {
            WithArguments("--job-manager-task-id");
            if (!string.IsNullOrEmpty(jobManagerTaskId))
            {
                 WithArguments(jobManagerTaskId);
            }

            return this;
        }

        /// <summary>
        /// A list of files that the Batch service will download to the compute node before running the command line. Files listed under this element are located in the task's working directory. There is a maximum size for the list of resource files.  When the max size is exceeded, the request will fail and the response error code will be RequestEntityTooLarge. If this occurs, the collection of ResourceFiles must be reduced in size. This can be achieved using .zip files, Application Packages, or Docker Containers. Space-separated resource references in filename=blobsource format.
        /// </summary>
        public AzureBatchJobCreateTask JobManagerTaskResourceFiles(string jobManagerTaskResourceFiles = null)
        {
            WithArguments("--job-manager-task-resource-files");
            if (!string.IsNullOrEmpty(jobManagerTaskResourceFiles))
            {
                 WithArguments(jobManagerTaskResourceFiles);
            }

            return this;
        }

        /// <summary>
        /// The id of an existing pool. All the tasks of the job will run on the specified pool.
        /// </summary>
        public AzureBatchJobCreateTask PoolId(string poolId = null)
        {
            WithArguments("--pool-id");
            if (!string.IsNullOrEmpty(poolId))
            {
                 WithArguments(poolId);
            }

            return this;
        }
     }
}
