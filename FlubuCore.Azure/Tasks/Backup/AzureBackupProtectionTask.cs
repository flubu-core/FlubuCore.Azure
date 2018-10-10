
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupProtectionTask : ExternalProcessTaskBase<AzureBackupProtectionTask>
     {
        
        /// <summary>
        /// Manage protection of your items, enable protection or disable it, or take on-demand backups.
        /// </summary>
        public AzureBackupProtectionTask()
        {
            WithArguments("az backup protection");
        }

        protected override string Description { get; set; }
        
     }
}
