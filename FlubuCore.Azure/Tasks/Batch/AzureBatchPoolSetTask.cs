
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchPoolSetTask : ExternalProcessTaskBase<AzureBatchPoolSetTask>
     {
        
        /// <summary>
        /// Update the properties of a Batch pool. Updating a property in a subgroup will reset the unspecified properties of that group.
        /// </summary>
        public AzureBatchPoolSetTask(string poolId = null)
        {
            WithArguments("az batch pool set");
WithArguments("--pool-id");
            if (!string.IsNullOrEmpty(poolId))
            {
                 WithArguments(poolId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// A file containing the pool patch parameter specification in JSON (formatted to match the respective REST API body). If this parameter is specified, all 'Pool Arguments' are ignored.
        /// </summary>
        public AzureBatchPoolSetTask JsonFile(string jsonFile = null)
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
        public AzureBatchPoolSetTask AccountEndpoint(string accountEndpoint = null)
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
        public AzureBatchPoolSetTask AccountKey(string accountKey = null)
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
        public AzureBatchPoolSetTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// A list of application packages to be installed on each compute node in the pool. Changes to application package references affect all new compute nodes joining the pool, but do not affect compute nodes that are already in the pool until they are rebooted or reimaged. If this element is present, it replaces any existing application package references. If you specify an empty collection, then all application package references are removed from the pool. If omitted, any existing application package references are left unchanged. Space-separated application IDs with optional version in 'id[#version]' format.
        /// </summary>
        public AzureBatchPoolSetTask ApplicationPackageReferences(string applicationPackageReferences = null)
        {
            WithArguments("--application-package-references");
            if (!string.IsNullOrEmpty(applicationPackageReferences))
            {
                 WithArguments(applicationPackageReferences);
            }

            return this;
        }

        /// <summary>
        /// A list of certificates to be installed on each compute node in the pool. If this element is present, it replaces any existing certificate references configured on the pool. If omitted, any existing certificate references are left unchanged. For Windows compute nodes, the Batch service installs the certificates to the specified certificate store and location. For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory. Space-separated certificate thumbprints.
        /// </summary>
        public AzureBatchPoolSetTask CertificateReferences(string certificateReferences = null)
        {
            WithArguments("--certificate-references");
            if (!string.IsNullOrEmpty(certificateReferences))
            {
                 WithArguments(certificateReferences);
            }

            return this;
        }

        /// <summary>
        /// A list of name-value pairs associated with the pool as metadata. If this element is present, it replaces any existing metadata configured on the pool. If you specify an empty collection, any metadata is removed from the pool. If omitted, any existing metadata is left unchanged. Space-separated values in 'key=value' format.
        /// </summary>
        public AzureBatchPoolSetTask Metadata(string metadata = null)
        {
            WithArguments("--metadata");
            if (!string.IsNullOrEmpty(metadata))
            {
                 WithArguments(metadata);
            }

            return this;
        }

        /// <summary>
        /// Required. The command line of the start task. The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. If the command line refers to file paths, it should use a relative path (relative to the task working directory), or use the Batch provided environment variable (<a href="https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables">https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables</a>).
        /// </summary>
        public AzureBatchPoolSetTask StartTaskCommandLine(string startTaskCommandLine = null)
        {
            WithArguments("--start-task-command-line");
            if (!string.IsNullOrEmpty(startTaskCommandLine))
            {
                 WithArguments(startTaskCommandLine);
            }

            return this;
        }

        /// <summary>
        /// A list of environment variable settings for the start task. Space-separated values in 'key=value' format.
        /// </summary>
        public AzureBatchPoolSetTask StartTaskEnvironmentSettings(string startTaskEnvironmentSettings = null)
        {
            WithArguments("--start-task-environment-settings");
            if (!string.IsNullOrEmpty(startTaskEnvironmentSettings))
            {
                 WithArguments(startTaskEnvironmentSettings);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of times the task may be retried. The Batch service retries a task if its exit code is nonzero. Note that this value specifically controls the number of retries. The Batch service will try the task once, and may then retry up to this limit. For example, if the maximum retry count is 3, Batch tries the task up to 4 times (one initial try and 3 retries). If the maximum retry count is 0, the Batch service does not retry the task. If the maximum retry count is -1, the Batch service retries the task without limit.
        /// </summary>
        public AzureBatchPoolSetTask StartTaskMaxTaskRetryCount(string startTaskMaxTaskRetryCount = null)
        {
            WithArguments("--start-task-max-task-retry-count");
            if (!string.IsNullOrEmpty(startTaskMaxTaskRetryCount))
            {
                 WithArguments(startTaskMaxTaskRetryCount);
            }

            return this;
        }

        /// <summary>
        /// A list of files that the Batch service will download to the compute node before running the command line.  There is a maximum size for the list of resource files. When the max size is exceeded, the request will fail and the response error code will be RequestEntityTooLarge. If this occurs, the collection of ResourceFiles must be reduced in size. This can be achieved using .zip files, Application Packages, or Docker Containers. Files listed under this element are located in the task's working directory. Space-separated resource references in filename=blobsource format.
        /// </summary>
        public AzureBatchPoolSetTask StartTaskResourceFiles(string startTaskResourceFiles = null)
        {
            WithArguments("--start-task-resource-files");
            if (!string.IsNullOrEmpty(startTaskResourceFiles))
            {
                 WithArguments(startTaskResourceFiles);
            }

            return this;
        }

        /// <summary>
        /// Whether the Batch service should wait for the start task to complete successfully (that is, to exit with exit code 0) before scheduling any tasks on the compute node. If true and the start task fails on a compute node, the Batch service retries the start task up to its maximum retry count (maxTaskRetryCount). If the task has still not completed successfully after all retries, then the Batch service marks the compute node unusable, and will not schedule tasks to it. This condition can be detected via the node state and failure info details. If false, the Batch service will not wait for the start task to complete. In this case, other tasks can start executing on the compute node while the start task is still running; and even if the start task fails, new tasks will continue to be scheduled on the node. The default is false. Specify either 'true' or 'false' to update the property.
        /// </summary>
        public AzureBatchPoolSetTask StartTaskWaitForSuccess(string startTaskWaitForSuccess = null)
        {
            WithArguments("--start-task-wait-for-success");
            if (!string.IsNullOrEmpty(startTaskWaitForSuccess))
            {
                 WithArguments(startTaskWaitForSuccess);
            }

            return this;
        }

        /// <summary>
        /// An ETag value associated with the version of the resource known to the client. The operation will be performed only if the resource's current ETag on the service exactly matches the value specified by the client.
        /// </summary>
        public AzureBatchPoolSetTask IfMatch(string ifMatch = null)
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
        public AzureBatchPoolSetTask IfModifiedSince(string ifModifiedSince = null)
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
        public AzureBatchPoolSetTask IfNoneMatch(string ifNoneMatch = null)
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
        public AzureBatchPoolSetTask IfUnmodifiedSince(string ifUnmodifiedSince = null)
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
