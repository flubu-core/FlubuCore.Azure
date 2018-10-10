
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupPolicySetTask : ExternalProcessTaskBase<AzureBackupPolicySetTask>
     {
        
        /// <summary>
        /// Update the properties of the backup policy.
        /// </summary>
        public AzureBackupPolicySetTask(string policy = null ,  string resourceGroup = null ,  string vaultName = null)
        {
            WithArguments("az backup policy set");
WithArguments("--policy");
            if (!string.IsNullOrEmpty(policy))
            {
                 WithArguments(policy);
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

        }

        protected override string Description { get; set; }
        
     }
}
