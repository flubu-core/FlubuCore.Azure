
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupRestoreFilesTask : ExternalProcessTaskBase<AzureBackupRestoreFilesTask>
     {
        
        /// <summary>
        /// Gives access to all files of a recovery point.
        /// </summary>
        public AzureBackupRestoreFilesTask()
        {
            WithArguments("az backup restore files");
        }

        protected override string Description { get; set; }
        
     }
}
