
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupProtectionBackupNowTask : ExternalProcessTaskBase<AzureBackupProtectionBackupNowTask>
     {
        
        /// <summary>
        /// Perform an on-demand backup of a backed up item.
        /// </summary>
        public AzureBackupProtectionBackupNowTask(string containerName = null ,  string itemName = null ,  string resourceGroup = null ,  string retainUntil = null ,  string vaultName = null)
        {
            WithArguments("az backup protection backup-now");
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

WithArguments("--retain-until");
            if (!string.IsNullOrEmpty(retainUntil))
            {
                 WithArguments(retainUntil);
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
