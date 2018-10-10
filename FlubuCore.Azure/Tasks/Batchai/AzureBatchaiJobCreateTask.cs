
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiJobCreateTask : ExternalProcessTaskBase<AzureBatchaiJobCreateTask>
     {
        
        /// <summary>
        /// Create a job.
        /// </summary>
        public AzureBatchaiJobCreateTask(string cluster = null ,  string configFile = null ,  string experiment = null ,  string name = null ,  string resourceGroup = null ,  string workspace = null)
        {
            WithArguments("az batchai job create");
WithArguments("--cluster");
            if (!string.IsNullOrEmpty(cluster))
            {
                 WithArguments(cluster);
            }

WithArguments("--config-file");
            if (!string.IsNullOrEmpty(configFile))
            {
                 WithArguments(configFile);
            }

WithArguments("--experiment");
            if (!string.IsNullOrEmpty(experiment))
            {
                 WithArguments(experiment);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--workspace");
            if (!string.IsNullOrEmpty(workspace))
            {
                 WithArguments(workspace);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Relative mount path for Azure File Share. The File Share will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/<relative_mount_path> folder.
        /// </summary>
        public AzureBatchaiJobCreateTask AfsMountPath(string afsMountPath = null)
        {
            WithArguments("--afs-mount-path");
            if (!string.IsNullOrEmpty(afsMountPath))
            {
                 WithArguments(afsMountPath);
            }

            return this;
        }

        /// <summary>
        /// Name of Azure File Share to mount during the job execution. The File Share will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name.  Multiple shares can be mounted using configuration file (see --config-file option).
        /// </summary>
        public AzureBatchaiJobCreateTask AfsName(string afsName = null)
        {
            WithArguments("--afs-name");
            if (!string.IsNullOrEmpty(afsName))
            {
                 WithArguments(afsName);
            }

            return this;
        }

        /// <summary>
        /// Relative mount path for Azure Storage Blob Container. The container will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/<relative_mount_path> folder.
        /// </summary>
        public AzureBatchaiJobCreateTask BfsMountPath(string bfsMountPath = null)
        {
            WithArguments("--bfs-mount-path");
            if (!string.IsNullOrEmpty(bfsMountPath))
            {
                 WithArguments(bfsMountPath);
            }

            return this;
        }

        /// <summary>
        /// Name of Azure Storage Blob Container to mount during the job execution. The container will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name. Multiple containers can be mounted using configuration file (see --config-file option).
        /// </summary>
        public AzureBatchaiJobCreateTask BfsName(string bfsName = null)
        {
            WithArguments("--bfs-name");
            if (!string.IsNullOrEmpty(bfsName))
            {
                 WithArguments(bfsName);
            }

            return this;
        }

        /// <summary>
        /// Storage account key. Required if the storage account belongs to a different subscription. Can be specified using AZURE_BATCHAI_STORAGE_KEY environment variable.
        /// </summary>
        public AzureBatchaiJobCreateTask StorageAccountKey(string storageAccountKey = null)
        {
            WithArguments("--storage-account-key");
            if (!string.IsNullOrEmpty(storageAccountKey))
            {
                 WithArguments(storageAccountKey);
            }

            return this;
        }

        /// <summary>
        /// Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted on each cluster node. Can be specified using AZURE_BATCHAI_STORAGE_ACCOUNT environment variable.
        /// </summary>
        public AzureBatchaiJobCreateTask StorageAccountName(string storageAccountName = null)
        {
            WithArguments("--storage-account-name");
            if (!string.IsNullOrEmpty(storageAccountName))
            {
                 WithArguments(storageAccountName);
            }

            return this;
        }

        /// <summary>
        /// Name or ARM ID of the file server to be mounted during the job execution. You need to provide ARM ID if the file server belongs to a different workspace. You can configure multiple file servers using job's  configuration file.
        /// </summary>
        public AzureBatchaiJobCreateTask Nfs(string nfs = null)
        {
            WithArguments("--nfs");
            if (!string.IsNullOrEmpty(nfs))
            {
                 WithArguments(nfs);
            }

            return this;
        }

        /// <summary>
        /// Relative mount path for NFS. The NFS will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/<relative_mount_path> folder.
        /// </summary>
        public AzureBatchaiJobCreateTask NfsMountPath(string nfsMountPath = null)
        {
            WithArguments("--nfs-mount-path");
            if (!string.IsNullOrEmpty(nfsMountPath))
            {
                 WithArguments(nfsMountPath);
            }

            return this;
        }
     }
}
