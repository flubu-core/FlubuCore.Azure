
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupItemSetPolicyTask : ExternalProcessTaskBase<AzureBackupItemSetPolicyTask>
     {
        
        /// <summary>
        /// Update the policy associated with this item.
        /// </summary>
        public AzureBackupItemSetPolicyTask(string containerName = null ,  string name = null ,  string policyName = null ,  string resourceGroup = null ,  string vaultName = null)
        {
            WithArguments("az backup item set-policy");
WithArguments("--container-name");
            if (!string.IsNullOrEmpty(containerName))
            {
                 WithArguments(containerName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

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

        }

        protected override string Description { get; set; }
        
     }
}
