
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultStoragePurgeTask : ExternalProcessTaskBase<AzureKeyvaultStoragePurgeTask>
     {
        
        /// <summary>
        /// Permanently deletes the specified storage account.
        /// </summary>
        public AzureKeyvaultStoragePurgeTask(string name = null ,  string vaultName = null)
        {
            WithArguments("az keyvault storage purge");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
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
