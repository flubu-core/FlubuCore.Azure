
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupVaultTask : ExternalProcessTaskBase<AzureBackupVaultTask>
     {
        
        /// <summary>
        /// Online storage entity in Azure used to hold data such as backup copies, recovery points and backup policies.
        /// </summary>
        public AzureBackupVaultTask()
        {
            WithArguments("az backup vault");
        }

        protected override string Description { get; set; }
        
     }
}
