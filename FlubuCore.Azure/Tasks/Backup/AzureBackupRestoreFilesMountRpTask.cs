
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupRestoreFilesMountRpTask : ExternalProcessTaskBase<AzureBackupRestoreFilesMountRpTask>
     {
        
        /// <summary>
        /// Download a script which mounts files of a recovery point.
        /// </summary>
        public AzureBackupRestoreFilesMountRpTask(string containerName = null ,  string itemName = null ,  string resourceGroup = null ,  string rpName = null ,  string vaultName = null)
        {
            WithArguments("az backup restore files mount-rp");
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

WithArguments("--vault-name");
            if (!string.IsNullOrEmpty(vaultName))
            {
                 WithArguments(vaultName);
            }

        }

        protected override string Description { get; set; }
        
     }
}
