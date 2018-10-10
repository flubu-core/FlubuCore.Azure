
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupRecoverypointTask : ExternalProcessTaskBase<AzureBackupRecoverypointTask>
     {
        
        /// <summary>
        /// A snapshot of data at that point-of-time, stored in Recovery Services Vault, from which you can restore information.
        /// </summary>
        public AzureBackupRecoverypointTask()
        {
            WithArguments("az backup recoverypoint");
        }

        protected override string Description { get; set; }
        
     }
}
