
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchPoolResetTask : ExternalProcessTaskBase<AzureBatchPoolResetTask>
     {
        
        /// <summary>
        /// Update the properties of a Batch pool. Unspecified properties which can be updated are reset to their defaults.
        /// </summary>
        public AzureBatchPoolResetTask(string poolId = null)
        {
            WithArguments("az batch pool reset");
WithArguments("--pool-id");
            if (!string.IsNullOrEmpty(poolId))
            {
                 WithArguments(poolId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The file containing pool update properties parameter specification in JSON(formatted to match REST API request body). If this parameter is specified, all 'Pool Update Properties Parameter Arguments' are ignored.
        /// </summary>
        public AzureBatchPoolResetTask JsonFile(string jsonFile = null)
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
        public AzureBatchPoolResetTask AccountEndpoint(string accountEndpoint = null)
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
        public AzureBatchPoolResetTask AccountKey(string accountKey = null)
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
        public AzureBatchPoolResetTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// Required. A list of application packages to be installed on each compute node in the pool. The list replaces any existing application package references on the pool. Changes to application package references affect all new compute nodes joining the pool, but do not affect compute nodes that are already in the pool until they are rebooted or reimaged. If omitted, or if you specify an empty collection, any existing application packages references are removed from the pool.
        /// </summary>
        public AzureBatchPoolResetTask ApplicationPackageReferences(string applicationPackageReferences = null)
        {
            WithArguments("--application-package-references");
            if (!string.IsNullOrEmpty(applicationPackageReferences))
            {
                 WithArguments(applicationPackageReferences);
            }

            return this;
        }

        /// <summary>
        /// Required. A list of certificates to be installed on each compute node in the pool. This list replaces any existing certificate references configured on the pool. If you specify an empty collection, any existing certificate references are removed from the pool. For Windows compute nodes, the Batch service installs the certificates to the specified certificate store and location. For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory.
        /// </summary>
        public AzureBatchPoolResetTask CertificateReferences(string certificateReferences = null)
        {
            WithArguments("--certificate-references");
            if (!string.IsNullOrEmpty(certificateReferences))
            {
                 WithArguments(certificateReferences);
            }

            return this;
        }

        /// <summary>
        /// Required. A list of name-value pairs associated with the pool as metadata. This list replaces any existing metadata configured on the pool. If omitted, or if you specify an empty collection, any existing metadata is removed from the pool.
        /// </summary>
        public AzureBatchPoolResetTask Metadata(string metadata = null)
        {
            WithArguments("--metadata");
            if (!string.IsNullOrEmpty(metadata))
            {
                 WithArguments(metadata);
            }

            return this;
        }

        /// <summary>
        /// The command line of the start task. The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux.
        /// </summary>
        public AzureBatchPoolResetTask StartTaskCommandLine(string startTaskCommandLine = null)
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
        public AzureBatchPoolResetTask StartTaskEnvironmentSettings(string startTaskEnvironmentSettings = null)
        {
            WithArguments("--start-task-environment-settings");
            if (!string.IsNullOrEmpty(startTaskEnvironmentSettings))
            {
                 WithArguments(startTaskEnvironmentSettings);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of times the task may be retried.
        /// </summary>
        public AzureBatchPoolResetTask StartTaskMaxTaskRetryCount(string startTaskMaxTaskRetryCount = null)
        {
            WithArguments("--start-task-max-task-retry-count");
            if (!string.IsNullOrEmpty(startTaskMaxTaskRetryCount))
            {
                 WithArguments(startTaskMaxTaskRetryCount);
            }

            return this;
        }

        /// <summary>
        /// Whether the Batch service should wait for the start task to complete successfully (that is, to exit with exit code 0) before scheduling any tasks on the compute node. True if flag present, otherwise defaults to False.
        /// </summary>
        public AzureBatchPoolResetTask StartTaskWaitForSuccess(string startTaskWaitForSuccess = null)
        {
            WithArguments("--start-task-wait-for-success");
            if (!string.IsNullOrEmpty(startTaskWaitForSuccess))
            {
                 WithArguments(startTaskWaitForSuccess);
            }

            return this;
        }
     }
}
