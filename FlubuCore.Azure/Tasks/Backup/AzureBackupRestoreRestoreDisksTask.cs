
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupRestoreRestoreDisksTask : ExternalProcessTaskBase<AzureBackupRestoreRestoreDisksTask>
     {
        
        /// <summary>
        /// Restore disks of the backed VM from the specified recovery point.
        /// </summary>
        public AzureBackupRestoreRestoreDisksTask(string containerName = null ,  string itemName = null ,  string resourceGroup = null ,  string rpName = null ,  string storageAccount = null ,  string vaultName = null)
        {
            WithArguments("az backup restore restore-disks");
WithArguments("--container-name");
            if (!string.IsNullOrEmpty(containerName))
            {
                 WithArguments(containerName);
            }

WithArguments("--item-name");
            if (!string.IsNullOrEmpty(itemName))
            {
                 WithArguments(itemName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--rp-name");
            if (!string.IsNullOrEmpty(rpName))
            {
                 WithArguments(rpName);
            }

WithArguments("--storage-account");
            if (!string.IsNullOrEmpty(storageAccount))
            {
                 WithArguments(storageAccount);
            }

WithArguments("--vault-name");
            if (!string.IsNullOrEmpty(vaultName))
            {
                 WithArguments(vaultName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Use this flag when you want disks to be restored to the staging storage account using the --storage-account parameter. When not specified, disks will be restored to their original storage accounts. Default: false.
        /// </summary>
        public AzureBackupRestoreRestoreDisksTask RestoreToStagingStorageAccount(string restoreToStagingStorageAccount = null)
        {
            WithArguments("--restore-to-staging-storage-account");
            if (!string.IsNullOrEmpty(restoreToStagingStorageAccount))
            {
                 WithArguments(restoreToStagingStorageAccount);
            }

            return this;
        }
     }
}
