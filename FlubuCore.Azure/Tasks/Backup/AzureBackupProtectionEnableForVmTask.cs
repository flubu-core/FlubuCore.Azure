
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupProtectionEnableForVmTask : ExternalProcessTaskBase<AzureBackupProtectionEnableForVmTask>
     {
        
        /// <summary>
        /// Start protecting a previously unprotected Azure VM as per the specified policy to a Recovery services vault.
        /// </summary>
        public AzureBackupProtectionEnableForVmTask(string policyName = null ,  string resourceGroup = null ,  string vaultName = null ,  string vm = null)
        {
            WithArguments("az backup protection enable-for-vm");
WithArguments("--policy-name");
            if (!string.IsNullOrEmpty(policyName))
            {
                 WithArguments(policyName);
            }

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

WithArguments("--vm");
            if (!string.IsNullOrEmpty(vm))
            {
                 WithArguments(vm);
            }

        }

        protected override string Description { get; set; }
        
     }
}
