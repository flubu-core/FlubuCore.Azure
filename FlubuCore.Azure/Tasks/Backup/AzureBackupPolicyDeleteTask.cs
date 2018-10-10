
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupPolicyDeleteTask : ExternalProcessTaskBase<AzureBackupPolicyDeleteTask>
     {
        
        /// <summary>
        /// Before you can delete a Backup protection policy, the policy must not have any associated Backup items. To  associate another policy with a Backup item, use the backup item set-policy command.
        /// </summary>
        public AzureBackupPolicyDeleteTask(string name = null ,  string resourceGroup = null ,  string vaultName = null)
        {
            WithArguments("az backup policy delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
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
