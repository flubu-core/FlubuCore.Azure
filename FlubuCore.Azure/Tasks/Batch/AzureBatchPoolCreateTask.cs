
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchPoolCreateTask : ExternalProcessTaskBase<AzureBatchPoolCreateTask>
     {
        
        /// <summary>
        /// Create a Batch pool in an account. When creating a pool, choose arguments from either Cloud Services Configuration or Virtual Machine Configuration.
        /// </summary>
        public AzureBatchPoolCreateTask()
        {
            WithArguments("az batch pool create");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// A file containing the pool specification in JSON (formatted to match the respective REST API body). If this parameter is specified, all 'Pool Arguments' are ignored.
        /// </summary>
        public AzureBatchPoolCreateTask JsonFile(string jsonFile = null)
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
        public AzureBatchPoolCreateTask AccountEndpoint(string accountEndpoint = null)
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
        public AzureBatchPoolCreateTask AccountKey(string accountKey = null)
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
        public AzureBatchPoolCreateTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// The list of application licenses the Batch service will make available on each compute node in the pool. The list of application licenses must be a subset of available Batch service application licenses. If a license is requested which is not supported, pool creation will fail. Space-separated values.
        /// </summary>
        public AzureBatchPoolCreateTask ApplicationLicenses(string applicationLicenses = null)
        {
            WithArguments("--application-licenses");
            if (!string.IsNullOrEmpty(applicationLicenses))
            {
                 WithArguments(applicationLicenses);
            }

            return this;
        }

        /// <summary>
        /// The list of application packages to be installed on each compute node in the pool. Space-separated application IDs with optional version in 'id[#version]' format.
        /// </summary>
        public AzureBatchPoolCreateTask ApplicationPackageReferences(string applicationPackageReferences = null)
        {
            WithArguments("--application-package-references");
            if (!string.IsNullOrEmpty(applicationPackageReferences))
            {
                 WithArguments(applicationPackageReferences);
            }

            return this;
        }

        /// <summary>
        /// A formula for the desired number of compute nodes in the pool. The formula is checked for validity before the pool is created. If the formula is not valid, the Batch service rejects the request with detailed error information. For more information about specifying this formula, see <a href="https://azure.microsoft.com/documentation/articles/batch-automatic-scaling/">https://azure.microsoft.com/documentation/articles/batch-automatic-scaling/</a>.
        /// </summary>
        public AzureBatchPoolCreateTask AutoScaleFormula(string autoScaleFormula = null)
        {
            WithArguments("--auto-scale-formula");
            if (!string.IsNullOrEmpty(autoScaleFormula))
            {
                 WithArguments(autoScaleFormula);
            }

            return this;
        }

        /// <summary>
        /// The list of certificates to be installed on each compute node in the pool. For Windows compute nodes, the Batch service installs the certificates to the specified certificate store and location. For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory. Space-separated certificate thumbprints.
        /// </summary>
        public AzureBatchPoolCreateTask CertificateReferences(string certificateReferences = null)
        {
            WithArguments("--certificate-references");
            if (!string.IsNullOrEmpty(certificateReferences))
            {
                 WithArguments(certificateReferences);
            }

            return this;
        }

        /// <summary>
        /// Whether the pool permits direct communication between nodes. Enabling inter-node communication limits the maximum size of the pool due to deployment restrictions on the nodes of the pool. This may result in the pool not reaching its desired size. The default value is false. True if flag present.
        /// </summary>
        public AzureBatchPoolCreateTask EnableInterNodeCommunication(string enableInterNodeCommunication = null)
        {
            WithArguments("--enable-inter-node-communication");
            if (!string.IsNullOrEmpty(enableInterNodeCommunication))
            {
                 WithArguments(enableInterNodeCommunication);
            }

            return this;
        }

        /// <summary>
        /// Required. A string that uniquely identifies the pool within the account. The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two pool IDs within an account that differ only by case).
        /// </summary>
        public AzureBatchPoolCreateTask Id(string id = null)
        {
            WithArguments("--id");
            if (!string.IsNullOrEmpty(id))
            {
                 WithArguments(id);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of tasks that can run concurrently on a single compute node in the pool. The default value is 1. The maximum value of this setting depends on the size of the compute nodes in the pool (the vmSize setting).
        /// </summary>
        public AzureBatchPoolCreateTask MaxTasksPerNode(string maxTasksPerNode = null)
        {
            WithArguments("--max-tasks-per-node");
            if (!string.IsNullOrEmpty(maxTasksPerNode))
            {
                 WithArguments(maxTasksPerNode);
            }

            return this;
        }

        /// <summary>
        /// A list of name-value pairs associated with the pool as metadata. The Batch service does not assign any meaning to metadata; it is solely for the use of user code. Space-separated values in 'key=value' format.
        /// </summary>
        public AzureBatchPoolCreateTask Metadata(string metadata = null)
        {
            WithArguments("--metadata");
            if (!string.IsNullOrEmpty(metadata))
            {
                 WithArguments(metadata);
            }

            return this;
        }

        /// <summary>
        /// The timeout for allocation of compute nodes to the pool. This timeout applies only to manual scaling; it has no effect when enableAutoScale is set to true. The default value is 15 minutes. The minimum value is 5 minutes. If you specify a value less than 5 minutes, the Batch service returns an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). Expected format is an ISO-8601 duration.
        /// </summary>
        public AzureBatchPoolCreateTask ResizeTimeout(string resizeTimeout = null)
        {
            WithArguments("--resize-timeout");
            if (!string.IsNullOrEmpty(resizeTimeout))
            {
                 WithArguments(resizeTimeout);
            }

            return this;
        }

        /// <summary>
        /// The desired number of dedicated compute nodes in the pool. This property must not be specified if enableAutoScale is set to true. If enableAutoScale is set to false, then you must set either targetDedicatedNodes, targetLowPriorityNodes, or both.
        /// </summary>
        public AzureBatchPoolCreateTask TargetDedicatedNodes(string targetDedicatedNodes = null)
        {
            WithArguments("--target-dedicated-nodes");
            if (!string.IsNullOrEmpty(targetDedicatedNodes))
            {
                 WithArguments(targetDedicatedNodes);
            }

            return this;
        }

        /// <summary>
        /// The desired number of low-priority compute nodes in the pool. This property must not be specified if enableAutoScale is set to true. If enableAutoScale is set to false, then you must set either targetDedicatedNodes, targetLowPriorityNodes, or both.
        /// </summary>
        public AzureBatchPoolCreateTask TargetLowPriorityNodes(string targetLowPriorityNodes = null)
        {
            WithArguments("--target-low-priority-nodes");
            if (!string.IsNullOrEmpty(targetLowPriorityNodes))
            {
                 WithArguments(targetLowPriorityNodes);
            }

            return this;
        }

        /// <summary>
        /// Required. The size of virtual machines in the pool. All virtual machines in a pool are the same size. For information about available sizes of virtual machines for Cloud Services pools (pools created with cloudServiceConfiguration), see Sizes for Cloud Services (<a href="https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/">https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/</a>). Batch supports all Cloud Services VM sizes except ExtraSmall, A1V2 and A2V2. For information about available VM sizes for pools using images from the Virtual Machines Marketplace (pools created with virtualMachineConfiguration) see Sizes for Virtual Machines (Linux) (<a href="https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/">https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/</a>) or Sizes for Virtual Machines (Windows) (<a href="https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/">https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/</a>). Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series).
        /// </summary>
        public AzureBatchPoolCreateTask VmSize(string vmSize = null)
        {
            WithArguments("--vm-size");
            if (!string.IsNullOrEmpty(vmSize))
            {
                 WithArguments(vmSize);
            }

            return this;
        }

        /// <summary>
        /// Required. The Azure Guest OS family to be installed on the virtual machines in the pool. Possible values are: 2 - OS Family 2, equivalent to Windows Server 2008 R2 SP1. 3 - OS Family 3, equivalent to Windows Server 2012. 4 - OS Family 4, equivalent to Windows Server 2012 R2. 5 - OS Family 5, equivalent to Windows Server 2016. For more information, see Azure Guest OS Releases (<a href="https://azure.microsoft.com/documentation/articles/cloud-services-guestos-update-matrix/#releases">https://azure.microsoft.com/documentation/articles/cloud-services-guestos-update-matrix/#releases</a>).
        /// </summary>
        public AzureBatchPoolCreateTask OsFamily(string osFamily = null)
        {
            WithArguments("--os-family");
            if (!string.IsNullOrEmpty(osFamily))
            {
                 WithArguments(osFamily);
            }

            return this;
        }

        /// <summary>
        /// Required. The command line of the start task. The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. If the command line refers to file paths, it should use a relative path (relative to the task working directory), or use the Batch provided environment variable (<a href="https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables">https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables</a>).
        /// </summary>
        public AzureBatchPoolCreateTask StartTaskCommandLine(string startTaskCommandLine = null)
        {
            WithArguments("--start-task-command-line");
            if (!string.IsNullOrEmpty(startTaskCommandLine))
            {
                 WithArguments(startTaskCommandLine);
            }

            return this;
        }

        /// <summary>
        /// A list of files that the Batch service will download to the compute node before running the command line.  There is a maximum size for the list of resource files. When the max size is exceeded, the request will fail and the response error code will be RequestEntityTooLarge. If this occurs, the collection of ResourceFiles must be reduced in size. This can be achieved using .zip files, Application Packages, or Docker Containers. Files listed under this element are located in the task's working directory. Space-separated resource references in filename=blobsource format.
        /// </summary>
        public AzureBatchPoolCreateTask StartTaskResourceFiles(string startTaskResourceFiles = null)
        {
            WithArguments("--start-task-resource-files");
            if (!string.IsNullOrEmpty(startTaskResourceFiles))
            {
                 WithArguments(startTaskResourceFiles);
            }

            return this;
        }

        /// <summary>
        /// Whether the Batch service should wait for the start task to complete successfully (that is, to exit with exit code 0) before scheduling any tasks on the compute node. If true and the start task fails on a compute node, the Batch service retries the start task up to its maximum retry count (maxTaskRetryCount). If the task has still not completed successfully after all retries, then the Batch service marks the compute node unusable, and will not schedule tasks to it. This condition can be detected via the node state and failure info details. If false, the Batch service will not wait for the start task to complete. In this case, other tasks can start executing on the compute node while the start task is still running; and even if the start task fails, new tasks will continue to be scheduled on the node. The default is false. True if flag present.
        /// </summary>
        public AzureBatchPoolCreateTask StartTaskWaitForSuccess(string startTaskWaitForSuccess = null)
        {
            WithArguments("--start-task-wait-for-success");
            if (!string.IsNullOrEmpty(startTaskWaitForSuccess))
            {
                 WithArguments(startTaskWaitForSuccess);
            }

            return this;
        }

        /// <summary>
        /// OS image reference. This can be either 'publisher:offer:sku[:version]' format, or a fully qualified ARM image id of the form '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/images/{imageName}'. If 'publisher:offer:sku[:version]' format, version is optional and if omitted latest will be used. Valid values can be retrieved via 'az batch pool node-agent-skus list'. For example: 'MicrosoftWindowsServer:WindowsServer:2012-R2-Datacenter:latest'.
        /// </summary>
        public AzureBatchPoolCreateTask Image(string image = null)
        {
            WithArguments("--image");
            if (!string.IsNullOrEmpty(image))
            {
                 WithArguments(image);
            }

            return this;
        }

        /// <summary>
        /// Required. The SKU of the Batch node agent to be provisioned on compute nodes in the pool. The Batch node agent is a program that runs on each node in the pool, and provides the command-and-control interface between the node and the Batch service. There are different implementations of the node agent, known as SKUs, for different operating systems. You must specify a node agent SKU which matches the selected image reference. To get the list of supported node agent SKUs along with their list of verified image references, see the 'List supported node agent SKUs' operation.
        /// </summary>
        public AzureBatchPoolCreateTask NodeAgentSkuId(string nodeAgentSkuId = null)
        {
            WithArguments("--node-agent-sku-id");
            if (!string.IsNullOrEmpty(nodeAgentSkuId))
            {
                 WithArguments(nodeAgentSkuId);
            }

            return this;
        }
     }
}
