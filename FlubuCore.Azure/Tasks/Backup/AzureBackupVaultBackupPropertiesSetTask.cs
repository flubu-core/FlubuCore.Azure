
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupVaultBackupPropertiesSetTask : ExternalProcessTaskBase<AzureBackupVaultBackupPropertiesSetTask>
     {
        
        /// <summary>
        /// Sets backup related properties of the Recovery Services vault.
        /// </summary>
        public AzureBackupVaultBackupPropertiesSetTask(string backupStorageRedundancy = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az backup vault backup-properties set");
WithArguments("--backup-storage-redundancy");
            if (!string.IsNullOrEmpty(backupStorageRedundancy))
            {
                 WithArguments(backupStorageRedundancy);
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

        }

        protected override string Description { get; set; }
        
     }
}
