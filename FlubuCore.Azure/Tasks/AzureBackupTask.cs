
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureBackupTask : ExternalProcessTaskBase<AzureBackupTask>
     {
        
        /// <summary>
        /// Manage Azure Backups.
        /// </summary>
        public AzureBackupTask()
        {
            WithArguments("az backup");
        }

        protected override string Description { get; set; }
        
     }
}
