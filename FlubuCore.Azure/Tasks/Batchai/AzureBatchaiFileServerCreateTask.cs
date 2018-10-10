
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiFileServerCreateTask : ExternalProcessTaskBase<AzureBatchaiFileServerCreateTask>
     {
        
        /// <summary>
        /// Create a file server.
        /// </summary>
        public AzureBatchaiFileServerCreateTask(string name = null ,  string resourceGroup = null ,  string workspace = null)
        {
            WithArguments("az batchai file-server create");
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
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureBatchaiFileServerCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// VM size.
        /// </summary>
        public AzureBatchaiFileServerCreateTask VmSize(string vmSize = null)
        {
            WithArguments("--vm-size");
            if (!string.IsNullOrEmpty(vmSize))
            {
                 WithArguments(vmSize);
            }

            return this;
        }

        /// <summary>
        /// Generate SSH public and private key files in ~/.ssh directory (if missing).
        /// </summary>
        public AzureBatchaiFileServerCreateTask GenerateSshKeys(string generateSshKeys = null)
        {
            WithArguments("--generate-ssh-keys");
            if (!string.IsNullOrEmpty(generateSshKeys))
            {
                 WithArguments(generateSshKeys);
            }

            return this;
        }

        /// <summary>
        /// Optional password for the admin user created on the NFS node.
        /// </summary>
        public AzureBatchaiFileServerCreateTask Password(string password = null)
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
        public AzureBatchaiFileServerCreateTask SshKey(string sshKey = null)
        {
            WithArguments("--ssh-key");
            if (!string.IsNullOrEmpty(sshKey))
            {
                 WithArguments(sshKey);
            }

            return this;
        }

        /// <summary>
        /// Name of admin user account to be created on NFS node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.
        /// </summary>
        public AzureBatchaiFileServerCreateTask UserName(string userName = null)
        {
            WithArguments("--user-name");
            if (!string.IsNullOrEmpty(userName))
            {
                 WithArguments(userName);
            }

            return this;
        }

        /// <summary>
        /// A path to a json file containing file server create parameters (json representation of azure.mgmt.batchai.models.FileServerCreateParameters). Note, parameters given via command line will overwrite parameters specified in the configuration file.
        /// </summary>
        public AzureBatchaiFileServerCreateTask ConfigFile(string configFile = null)
        {
            WithArguments("--config-file");
            if (!string.IsNullOrEmpty(configFile))
            {
                 WithArguments(configFile);
            }

            return this;
        }

        /// <summary>
        /// Caching type for premium disks. If not provided via command line or in configuration file, no caching will be used.
        /// </summary>
        public AzureBatchaiFileServerCreateTask CachingType(string cachingType = null)
        {
            WithArguments("--caching-type");
            if (!string.IsNullOrEmpty(cachingType))
            {
                 WithArguments(cachingType);
            }

            return this;
        }

        /// <summary>
        /// Number of disks.
        /// </summary>
        public AzureBatchaiFileServerCreateTask DiskCount(string diskCount = null)
        {
            WithArguments("--disk-count");
            if (!string.IsNullOrEmpty(diskCount))
            {
                 WithArguments(diskCount);
            }

            return this;
        }

        /// <summary>
        /// Disk size in Gb.
        /// </summary>
        public AzureBatchaiFileServerCreateTask DiskSize(string diskSize = null)
        {
            WithArguments("--disk-size");
            if (!string.IsNullOrEmpty(diskSize))
            {
                 WithArguments(diskSize);
            }

            return this;
        }

        /// <summary>
        /// The sku of storage account to persist VM.
        /// </summary>
        public AzureBatchaiFileServerCreateTask StorageSku(string storageSku = null)
        {
            WithArguments("--storage-sku");
            if (!string.IsNullOrEmpty(storageSku))
            {
                 WithArguments(storageSku);
            }

            return this;
        }

        /// <summary>
        /// ARM ID of a virtual network subnet to put the file server in. If not provided via command line or in the configuration file, Batch AI will create a new virtual network and subnet under your subscription.
        /// </summary>
        public AzureBatchaiFileServerCreateTask Subnet(string subnet = null)
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
