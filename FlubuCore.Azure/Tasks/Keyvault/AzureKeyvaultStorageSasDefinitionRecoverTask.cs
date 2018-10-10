
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultStorageSasDefinitionRecoverTask : ExternalProcessTaskBase<AzureKeyvaultStorageSasDefinitionRecoverTask>
     {
        
        /// <summary>
        /// Recovers the deleted SAS definition.
        /// </summary>
        public AzureKeyvaultStorageSasDefinitionRecoverTask(string accountName = null ,  string name = null ,  string vaultName = null)
        {
            WithArguments("az keyvault storage sas-definition recover");
WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

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
