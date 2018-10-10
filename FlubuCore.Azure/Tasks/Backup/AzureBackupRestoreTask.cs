
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupRestoreTask : ExternalProcessTaskBase<AzureBackupRestoreTask>
     {
        
        /// <summary>
        /// Restore backed up items from recovery points in a Recovery Services vault.
        /// </summary>
        public AzureBackupRestoreTask()
        {
            WithArguments("az backup restore");
        }

        protected override string Description { get; set; }
        
     }
}
