
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultSecretRestoreTask : ExternalProcessTaskBase<AzureKeyvaultSecretRestoreTask>
     {
        
        /// <summary>
        /// Restores a backed up secret to a vault.
        /// </summary>
        public AzureKeyvaultSecretRestoreTask(string filePath = null ,  string vaultName = null)
        {
            WithArguments("az keyvault secret restore");
WithArguments("--file-path");
            if (!string.IsNullOrEmpty(filePath))
            {
                 WithArguments(filePath);
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
