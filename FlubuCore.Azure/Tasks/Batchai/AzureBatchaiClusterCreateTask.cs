
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiClusterCreateTask : ExternalProcessTaskBase<AzureBatchaiClusterCreateTask>
     {
        
        /// <summary>
        /// Create a cluster.
        /// </summary>
        public AzureBatchaiClusterCreateTask(string name = null ,  string resourceGroup = null ,  string workspace = null)
        {
            WithArguments("az batchai cluster create");
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
        /// Generate SSH public and private key files in ~/.ssh directory (if missing).
        /// </summary>
        public AzureBatchaiClusterCreateTask GenerateSshKeys(string generateSshKeys = null)
        {
            WithArguments("--generate-ssh-keys");
            if (!string.IsNullOrEmpty(generateSshKeys))
            {
                 WithArguments(generateSshKeys);
            }

            return this;
        }

        /// <summary>
        /// Optional password for the admin user account to be created on each compute node.
        /// </summary>
        public AzureBatchaiClusterCreateTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// Optional SSH public key value or path. If ommited and no password specified, default SSH key (~/.ssh/id_rsa.pub) will be used.
        /// </summary>
        public AzureBatchaiClusterCreateTask SshKey(string sshKey = null)
        {
            WithArguments("--ssh-key");
            if (!string.IsNullOrEmpty(sshKey))
            {
                 WithArguments(sshKey);
            }

            return this;
        }

        /// <summary>
        /// Name of admin user account to be created on each compute node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.
        /// </summary>
        public AzureBatchaiClusterCreateTask UserName(string userName = null)
        {
            WithArguments("--user-name");
            if (!string.IsNullOrEmpty(userName))
            {
                 WithArguments(userName);
            }

            return this;
        }

        /// <summary>
        /// A path to a json file containing cluster create parameters (json representation of azure.mgmt.batchai.models.ClusterCreateParameters).
        /// </summary>
        public AzureBatchaiClusterCreateTask ConfigFile(string configFile = null)
        {
            WithArguments("--config-file");
            if (!string.IsNullOrEmpty(configFile))
            {
                 WithArguments(configFile);
            }

            return this;
        }

        /// <summary>
        /// If provided, the command will create a storage account in a new or existing resource group named "batchaiautostorage". It will also create Azure File Share with name "batchaishare", Azure Blob Container with name "batchaicontainer". The File Share and Blob Container will be mounted on each cluster node at $AZ_BATCHAI_MOUNT_ROOT/autoafs and $AZ_BATCHAI_MOUNT_ROOT/autobfs. If the resource group already exists and contains an approapriate storage account belonging to the same region as cluster, this command will reuse existing storage account.
        /// </summary>
        public AzureBatchaiClusterCreateTask UseAutoStorage(string useAutoStorage = null)
        {
            WithArguments("--use-auto-storage");
            if (!string.IsNullOrEmpty(useAutoStorage))
            {
                 WithArguments(useAutoStorage);
            }

            return this;
        }

        /// <summary>
        /// Relative mount path for Azure File share. The file share will be available at $AZ_BATCHAI_MOUNT_ROOT/<relative_mount_path> folder.
        /// </summary>
        public AzureBatchaiClusterCreateTask AfsMountPath(string afsMountPath = null)
        {
            WithArguments("--afs-mount-path");
            if (!string.IsNullOrEmpty(afsMountPath))
            {
                 WithArguments(afsMountPath);
            }

            return this;
        }

        /// <summary>
        /// Name of Azure File Share to be mounted on each cluster node. Must be used in conjunction with --storage-account-name. Multiple shares can be mounted using configuration file (see --config-file option).
        /// </summary>
        public AzureBatchaiClusterCreateTask AfsName(string afsName = null)
        {
            WithArguments("--afs-name");
            if (!string.IsNullOrEmpty(afsName))
            {
                 WithArguments(afsName);
            }

            return this;
        }

        /// <summary>
        /// Relative mount path for Azure Storage container. The container will be available at $AZ_BATCHAI_MOUNT_ROOT/<relative_mount_path> folder.
        /// </summary>
        public AzureBatchaiClusterCreateTask BfsMountPath(string bfsMountPath = null)
        {
            WithArguments("--bfs-mount-path");
            if (!string.IsNullOrEmpty(bfsMountPath))
            {
                 WithArguments(bfsMountPath);
            }

            return this;
        }

        /// <summary>
        /// Name of Azure Storage container to be mounted on each cluster node. Must be used in conjunction with --storage-account-name. Multiple containers can be mounted using configuration file (see --config-file option).
        /// </summary>
        public AzureBatchaiClusterCreateTask BfsName(string bfsName = null)
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
        public AzureBatchaiClusterCreateTask StorageAccountKey(string storageAccountKey = null)
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
        public AzureBatchaiClusterCreateTask StorageAccountName(string storageAccountName = null)
        {
            WithArguments("--storage-account-name");
            if (!string.IsNullOrEmpty(storageAccountName))
            {
                 WithArguments(storageAccountName);
            }

            return this;
        }

        /// <summary>
        /// Name or ARM ID of a file server to be mounted on each cluster node. You need to provide full ARM ID if the file server belongs to a different workspace. Multiple NFS can be mounted using configuration file (see --config-file option).
        /// </summary>
        public AzureBatchaiClusterCreateTask Nfs(string nfs = null)
        {
            WithArguments("--nfs");
            if (!string.IsNullOrEmpty(nfs))
            {
                 WithArguments(nfs);
            }

            return this;
        }

        /// <summary>
        /// Relative mount path for NFS. The NFS will be available at $AZ_BATCHAI_MOUNT_ROOT/<relative_mount_path> folder.
        /// </summary>
        public AzureBatchaiClusterCreateTask NfsMountPath(string nfsMountPath = null)
        {
            WithArguments("--nfs-mount-path");
            if (!string.IsNullOrEmpty(nfsMountPath))
            {
                 WithArguments(nfsMountPath);
            }

            return this;
        }

        /// <summary>
        /// ARM ID of a virtual machine image to be used for nodes creation. Note, you need to provide --image containing information about the base image used for this image creation.
        /// </summary>
        public AzureBatchaiClusterCreateTask CustomImage(string customImage = null)
        {
            WithArguments("--custom-image");
            if (!string.IsNullOrEmpty(customImage))
            {
                 WithArguments(customImage);
            }

            return this;
        }

        /// <summary>
        /// Operation system image for cluster nodes. The value may contain an alias (UbuntuLTS, UbuntuDSVM) or specify image details in the form "publisher:offer:sku:version". If image configuration is not provided via command line or configuration file, Batch AI will choose default OS image.
        /// </summary>
        public AzureBatchaiClusterCreateTask Image(string image = null)
        {
            WithArguments("--image");
            if (!string.IsNullOrEmpty(image))
            {
                 WithArguments(image);
            }

            return this;
        }

        /// <summary>
        /// Max nodes count for the auto-scale cluster.
        /// </summary>
        public AzureBatchaiClusterCreateTask Max(string max = null)
        {
            WithArguments("--max");
            if (!string.IsNullOrEmpty(max))
            {
                 WithArguments(max);
            }

            return this;
        }

        /// <summary>
        /// Min nodes count for the auto-scale cluster.
        /// </summary>
        public AzureBatchaiClusterCreateTask Min(string min = null)
        {
            WithArguments("--min");
            if (!string.IsNullOrEmpty(min))
            {
                 WithArguments(min);
            }

            return this;
        }

        /// <summary>
        /// Number of nodes which should be allocated immediately after cluster creation. If the cluster is in auto-scale mode, BatchAI can change the number of nodes later based on number of running and queued jobs.
        /// </summary>
        public AzureBatchaiClusterCreateTask Target(string target = null)
        {
            WithArguments("--target");
            if (!string.IsNullOrEmpty(target))
            {
                 WithArguments(target);
            }

            return this;
        }

        /// <summary>
        /// VM priority.
        /// </summary>
        public AzureBatchaiClusterCreateTask VmPriority(string vmPriority = null)
        {
            WithArguments("--vm-priority");
            if (!string.IsNullOrEmpty(vmPriority))
            {
                 WithArguments(vmPriority);
            }

            return this;
        }

        /// <summary>
        /// VM size for cluster nodes (e.g. Standard_NC6 for 1 GPU node).
        /// </summary>
        public AzureBatchaiClusterCreateTask VmSize(string vmSize = null)
        {
            WithArguments("--vm-size");
            if (!string.IsNullOrEmpty(vmSize))
            {
                 WithArguments(vmSize);
            }

            return this;
        }

        /// <summary>
        /// A command line which should be executed on each compute node when it's got allocated or rebooted. The task is executed in a bash subshell under root account.
        /// </summary>
        public AzureBatchaiClusterCreateTask SetupTask(string setupTask = null)
        {
            WithArguments("--setup-task");
            if (!string.IsNullOrEmpty(setupTask))
            {
                 WithArguments(setupTask);
            }

            return this;
        }

        /// <summary>
        /// Directory path to store where setup-task's logs. Note, Batch AI will create several helper directories under this path. The created directories are reported as stdOutErrPathSuffix by 'az cluster show' command.
        /// </summary>
        public AzureBatchaiClusterCreateTask SetupTaskOutput(string setupTaskOutput = null)
        {
            WithArguments("--setup-task-output");
            if (!string.IsNullOrEmpty(setupTaskOutput))
            {
                 WithArguments(setupTaskOutput);
            }

            return this;
        }

        /// <summary>
        /// ARM ID of a virtual network subnet to put the cluster in.
        /// </summary>
        public AzureBatchaiClusterCreateTask Subnet(string subnet = null)
        {
            WithArguments("--subnet");
            if (!string.IsNullOrEmpty(subnet))
            {
                 WithArguments(subnet);
            }

            return this;
        }
     }
}
