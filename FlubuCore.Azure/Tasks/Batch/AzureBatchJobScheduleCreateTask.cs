
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchJobScheduleCreateTask : ExternalProcessTaskBase<AzureBatchJobScheduleCreateTask>
     {
        
        /// <summary>
        /// Add a Batch job schedule to an account.
        /// </summary>
        public AzureBatchJobScheduleCreateTask()
        {
            WithArguments("az batch job-schedule create");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// A file containing the cloud job schedule specification in JSON (formatted to match the respective REST API body). If this parameter is specified, all 'Cloud Job Schedule Arguments' are ignored.
        /// </summary>
        public AzureBatchJobScheduleCreateTask JsonFile(string jsonFile = null)
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
        public AzureBatchJobScheduleCreateTask AccountEndpoint(string accountEndpoint = null)
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
        public AzureBatchJobScheduleCreateTask AccountKey(string accountKey = null)
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
        public AzureBatchJobScheduleCreateTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// Required. A string that uniquely identifies the schedule within the account. The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two IDs within an account that differ only by case).
        /// </summary>
        public AzureBatchJobScheduleCreateTask Id(string id = null)
        {
            WithArguments("--id");
            if (!string.IsNullOrEmpty(id))
            {
                 WithArguments(id);
            }

            return this;
        }

        /// <summary>
        /// A list of name-value pairs associated with the schedule as metadata. The Batch service does not assign any meaning to metadata; it is solely for the use of user code. Space-separated values in 'key=value' format.
        /// </summary>
        public AzureBatchJobScheduleCreateTask Metadata(string metadata = null)
        {
            WithArguments("--metadata");
            if (!string.IsNullOrEmpty(metadata))
            {
                 WithArguments(metadata);
            }

            return this;
        }

        /// <summary>
        /// The action the Batch service should take when all tasks in a job created under this schedule are in the completed state. Note that if a job contains no tasks, then all tasks are considered complete. This option is therefore most commonly used with a Job Manager task; if you want to use automatic job termination without a Job Manager, you should initially set onAllTasksComplete to noaction and update the job properties to set onAllTasksComplete to terminatejob once you have finished adding tasks. The default is noaction.
        /// </summary>
        public AzureBatchJobScheduleCreateTask OnAllTasksComplete(string onAllTasksComplete = null)
        {
            WithArguments("--on-all-tasks-complete");
            if (!string.IsNullOrEmpty(onAllTasksComplete))
            {
                 WithArguments(onAllTasksComplete);
            }

            return this;
        }

        /// <summary>
        /// The priority of jobs created under this schedule. Priority values can range from -1000 to 1000, with -1000 being the lowest priority and 1000 being the highest priority. The default value is 0. This priority is used as the default for all jobs under the job schedule. You can update a job's priority after it has been created using by using the update job API.
        /// </summary>
        public AzureBatchJobScheduleCreateTask Priority(string priority = null)
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
        public AzureBatchJobScheduleCreateTask UsesTaskDependencies(string usesTaskDependencies = null)
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
        public AzureBatchJobScheduleCreateTask JobMaxTaskRetryCount(string jobMaxTaskRetryCount = null)
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
        public AzureBatchJobScheduleCreateTask JobMaxWallClockTime(string jobMaxWallClockTime = null)
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
        public AzureBatchJobScheduleCreateTask JobManagerTaskCommandLine(string jobManagerTaskCommandLine = null)
        {
            WithArguments("--job-manager-task-command-line");
            if (!string.IsNullOrEmpty(jobManagerTaskCommandLine))
            {
                 WithArguments(jobManagerTaskCommandLine);
            }

            return this;
        }

        /// <summary>
        /// Required. A string that uniquely identifies the Job Manager task within the job. The ID can contain any combination of alphanumeric characters including hyphens and underscores and cannot contain more than 64 characters.
        /// </summary>
        public AzureBatchJobScheduleCreateTask JobManagerTaskId(string jobManagerTaskId = null)
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
        public AzureBatchJobScheduleCreateTask JobManagerTaskResourceFiles(string jobManagerTaskResourceFiles = null)
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
        public AzureBatchJobScheduleCreateTask PoolId(string poolId = null)
        {
            WithArguments("--pool-id");
            if (!string.IsNullOrEmpty(poolId))
            {
                 WithArguments(poolId);
            }

            return this;
        }

        /// <summary>
        /// A time after which no job will be created under this job schedule. The schedule will move to the completed state as soon as this deadline is past and there is no active job under this job schedule. If you do not specify a doNotRunAfter time, and you are creating a recurring job schedule, the job schedule will remain active until you explicitly terminate it. Expected format is an ISO-8601 timestamp.
        /// </summary>
        public AzureBatchJobScheduleCreateTask DoNotRunAfter(string doNotRunAfter = null)
        {
            WithArguments("--do-not-run-after");
            if (!string.IsNullOrEmpty(doNotRunAfter))
            {
                 WithArguments(doNotRunAfter);
            }

            return this;
        }

        /// <summary>
        /// The earliest time at which any job may be created under this job schedule. If you do not specify a doNotRunUntil time, the schedule becomes ready to create jobs immediately. Expected format is an ISO-8601 timestamp.
        /// </summary>
        public AzureBatchJobScheduleCreateTask DoNotRunUntil(string doNotRunUntil = null)
        {
            WithArguments("--do-not-run-until");
            if (!string.IsNullOrEmpty(doNotRunUntil))
            {
                 WithArguments(doNotRunUntil);
            }

            return this;
        }

        /// <summary>
        /// The time interval between the start times of two successive jobs under the job schedule. A job schedule can have at most one active job under it at any given time. Because a job schedule can have at most one active job under it at any given time, if it is time to create a new job under a job schedule, but the previous job is still running, the Batch service will not create the new job until the previous job finishes. If the previous job does not finish within the startWindow period of the new recurrenceInterval, then no new job will be scheduled for that interval. For recurring jobs, you should normally specify a jobManagerTask in the jobSpecification. If you do not use jobManagerTask, you will need an external process to monitor when jobs are created, add tasks to the jobs and terminate the jobs ready for the next recurrence. The default is that the schedule does not recur: one job is created, within the startWindow after the doNotRunUntil time, and the schedule is complete as soon as that job finishes. The minimum value is 1 minute. If you specify a lower value, the Batch service rejects the schedule with an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). Expected format is an ISO-8601 duration.
        /// </summary>
        public AzureBatchJobScheduleCreateTask RecurrenceInterval(string recurrenceInterval = null)
        {
            WithArguments("--recurrence-interval");
            if (!string.IsNullOrEmpty(recurrenceInterval))
            {
                 WithArguments(recurrenceInterval);
            }

            return this;
        }

        /// <summary>
        /// The time interval, starting from the time at which the schedule indicates a job should be created, within which a job must be created. If a job is not created within the startWindow interval, then the 'opportunity' is lost; no job will be created until the next recurrence of the schedule. If the schedule is recurring, and the startWindow is longer than the recurrence interval, then this is equivalent to an infinite startWindow, because the job that is 'due' in one recurrenceInterval is not carried forward into the next recurrence interval. The default is infinite. The minimum value is 1 minute. If you specify a lower value, the Batch service rejects the schedule with an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). Expected format is an ISO-8601 duration.
        /// </summary>
        public AzureBatchJobScheduleCreateTask StartWindow(string startWindow = null)
        {
            WithArguments("--start-window");
            if (!string.IsNullOrEmpty(startWindow))
            {
                 WithArguments(startWindow);
            }

            return this;
        }
     }
}
