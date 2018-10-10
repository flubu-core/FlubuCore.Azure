
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupProtectionDisableTask : ExternalProcessTaskBase<AzureBackupProtectionDisableTask>
     {
        
        /// <summary>
        /// Stop protecting a backed up Azure VM.
        /// </summary>
        public AzureBackupProtectionDisableTask(string containerName = null ,  string itemName = null ,  string resourceGroup = null ,  string vaultName = null)
        {
            WithArguments("az backup protection disable");
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

WithArguments("--vault-name");
            if (!string.IsNullOrEmpty(vaultName))
            {
                 WithArguments(vaultName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Option to delete existing backed up data in the Recovery services vault.
        /// </summary>
        public AzureBackupProtectionDisableTask DeleteBackupData(string deleteBackupData = null)
        {
            WithArguments("--delete-backup-data");
            if (!string.IsNullOrEmpty(deleteBackupData))
            {
                 WithArguments(deleteBackupData);
            }

            return this;
        }

        /// <summary>
        /// Do not prompt for confirmation.
        /// </summary>
        public AzureBackupProtectionDisableTask Yes(string yes = null)
        {
            WithArguments("--yes");
            if (!string.IsNullOrEmpty(yes))
            {
                 WithArguments(yes);
            }

            return this;
        }
     }
}
