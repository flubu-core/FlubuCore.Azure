
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchTaskCreateTask : ExternalProcessTaskBase<AzureBatchTaskCreateTask>
     {
        
        /// <summary>
        /// Create Batch tasks.
        /// </summary>
        public AzureBatchTaskCreateTask(string jobId = null)
        {
            WithArguments("az batch task create");
WithArguments("--job-id");
            if (!string.IsNullOrEmpty(jobId))
            {
                 WithArguments(jobId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Required. An opaque string representing the location of a compute node or a task that has run previously. You can pass the affinityId of a compute node to indicate that this task needs to run on that compute node. Note that this is just a soft affinity. If the target node is busy or unavailable at the time the task is scheduled, then the task will be scheduled elsewhere.
        /// </summary>
        public AzureBatchTaskCreateTask AffinityId(string affinityId = null)
        {
            WithArguments("--affinity-id");
            if (!string.IsNullOrEmpty(affinityId))
            {
                 WithArguments(affinityId);
            }

            return this;
        }

        /// <summary>
        /// The space-separated list of IDs specifying the application packages to be installed. Space-separated application IDs with optional version in 'id[#version]' format.
        /// </summary>
        public AzureBatchTaskCreateTask ApplicationPackageReferences(string applicationPackageReferences = null)
        {
            WithArguments("--application-package-references");
            if (!string.IsNullOrEmpty(applicationPackageReferences))
            {
                 WithArguments(applicationPackageReferences);
            }

            return this;
        }

        /// <summary>
        /// The command line of the task. The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux.
        /// </summary>
        public AzureBatchTaskCreateTask CommandLine(string commandLine = null)
        {
            WithArguments("--command-line");
            if (!string.IsNullOrEmpty(commandLine))
            {
                 WithArguments(commandLine);
            }

            return this;
        }

        /// <summary>
        /// A list of environment variable settings for the task. Space-separated values in 'key=value' format.
        /// </summary>
        public AzureBatchTaskCreateTask EnvironmentSettings(string environmentSettings = null)
        {
            WithArguments("--environment-settings");
            if (!string.IsNullOrEmpty(environmentSettings))
            {
                 WithArguments(environmentSettings);
            }

            return this;
        }

        /// <summary>
        /// The file containing the task(s) to create in JSON(formatted to match REST API request body). When submitting multiple tasks, accepts either an array of tasks or a TaskAddCollectionParamater. If this parameter is specified, all other parameters are ignored.
        /// </summary>
        public AzureBatchTaskCreateTask JsonFile(string jsonFile = null)
        {
            WithArguments("--json-file");
            if (!string.IsNullOrEmpty(jsonFile))
            {
                 WithArguments(jsonFile);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of times the task may be retried. The Batch service retries a task if its exit code is nonzero. Note that this value specifically controls the number of retries for the task executable due to a nonzero exit code. The Batch service will try the task once, and may then retry up to this limit. For example, if the maximum retry count is 3, Batch tries the task up to 4 times (one initial try and 3 retries). If the maximum retry count is 0, the Batch service does not retry the task after the first attempt. If the maximum retry count is -1, the Batch service retries the task without limit. Resource files and application packages are only downloaded again if the task is retried on a new compute node.
        /// </summary>
        public AzureBatchTaskCreateTask MaxTaskRetryCount(string maxTaskRetryCount = null)
        {
            WithArguments("--max-task-retry-count");
            if (!string.IsNullOrEmpty(maxTaskRetryCount))
            {
                 WithArguments(maxTaskRetryCount);
            }

            return this;
        }

        /// <summary>
        /// The maximum elapsed time that the task may run, measured from the time the task starts. If the task does not complete within the time limit, the Batch service terminates it. If this is not specified, there is no time limit on how long the task may run.
        /// </summary>
        public AzureBatchTaskCreateTask MaxWallClockTime(string maxWallClockTime = null)
        {
            WithArguments("--max-wall-clock-time");
            if (!string.IsNullOrEmpty(maxWallClockTime))
            {
                 WithArguments(maxWallClockTime);
            }

            return this;
        }

        /// <summary>
        /// A list of files that the Batch service will download to the compute node before running the command line. Space-separated resource references in filename=blobsource format.
        /// </summary>
        public AzureBatchTaskCreateTask ResourceFiles(string resourceFiles = null)
        {
            WithArguments("--resource-files");
            if (!string.IsNullOrEmpty(resourceFiles))
            {
                 WithArguments(resourceFiles);
            }

            return this;
        }

        /// <summary>
        /// The minimum time to retain the task directory on the compute node where it ran, from the time it completes execution. After this time, the Batch service may delete the task directory and all its contents. The default is infinite, i.e. the task directory will be retained until the compute node is removed or reimaged.
        /// </summary>
        public AzureBatchTaskCreateTask RetentionTime(string retentionTime = null)
        {
            WithArguments("--retention-time");
            if (!string.IsNullOrEmpty(retentionTime))
            {
                 WithArguments(retentionTime);
            }

            return this;
        }

        /// <summary>
        /// The ID of the task.
        /// </summary>
        public AzureBatchTaskCreateTask TaskId(string taskId = null)
        {
            WithArguments("--task-id");
            if (!string.IsNullOrEmpty(taskId))
            {
                 WithArguments(taskId);
            }

            return this;
        }

        /// <summary>
        /// Batch service endpoint. Alternatively, set by environment variable: AZURE_BATCH_ENDPOINT.
        /// </summary>
        public AzureBatchTaskCreateTask AccountEndpoint(string accountEndpoint = null)
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
        public AzureBatchTaskCreateTask AccountKey(string accountKey = null)
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
        public AzureBatchTaskCreateTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }
     }
}
