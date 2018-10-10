
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupVaultBackupPropertiesTask : ExternalProcessTaskBase<AzureBackupVaultBackupPropertiesTask>
     {
        
        /// <summary>
        /// Properties of the Recovery Services vault.
        /// </summary>
        public AzureBackupVaultBackupPropertiesTask()
        {
            WithArguments("az backup vault backup-properties");
        }

        protected override string Description { get; set; }
        
     }
}
