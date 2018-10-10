
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultKeyRestoreTask : ExternalProcessTaskBase<AzureKeyvaultKeyRestoreTask>
     {
        
        /// <summary>
        /// Restores a backed up key to a vault.
        /// </summary>
        public AzureKeyvaultKeyRestoreTask(string file = null ,  string vaultName = null)
        {
            WithArguments("az keyvault key restore");
WithArguments("--file");
            if (!string.IsNullOrEmpty(file))
            {
                 WithArguments(file);
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
