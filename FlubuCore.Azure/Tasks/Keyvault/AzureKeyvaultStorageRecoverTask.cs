
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultStorageRecoverTask : ExternalProcessTaskBase<AzureKeyvaultStorageRecoverTask>
     {
        
        /// <summary>
        /// Recovers the deleted storage account.
        /// </summary>
        public AzureKeyvaultStorageRecoverTask(string name = null ,  string vaultName = null)
        {
            WithArguments("az keyvault storage recover");
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
