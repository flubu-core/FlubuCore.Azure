
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupPolicyGetDefaultForVmTask : ExternalProcessTaskBase<AzureBackupPolicyGetDefaultForVmTask>
     {
        
        /// <summary>
        /// Get the default policy with default values to backup a VM.
        /// </summary>
        public AzureBackupPolicyGetDefaultForVmTask(string resourceGroup = null ,  string vaultName = null)
        {
            WithArguments("az backup policy get-default-for-vm");
WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
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
