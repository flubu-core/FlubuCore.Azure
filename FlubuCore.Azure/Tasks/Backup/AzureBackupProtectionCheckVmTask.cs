
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupProtectionCheckVmTask : ExternalProcessTaskBase<AzureBackupProtectionCheckVmTask>
     {
        
        /// <summary>
        /// Find out whether the virtual machine is protected or not. If protected, it returns the recovery services vault ID, otherwise it returns empty.
        /// </summary>
        public AzureBackupProtectionCheckVmTask(string vmId = null)
        {
            WithArguments("az backup protection check-vm");
WithArguments("--vm-id");
            if (!string.IsNullOrEmpty(vmId))
            {
                 WithArguments(vmId);
            }

        }

        protected override string Description { get; set; }
        
     }
}
