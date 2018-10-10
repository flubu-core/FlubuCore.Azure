
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultKeyDeleteTask : ExternalProcessTaskBase<AzureKeyvaultKeyDeleteTask>
     {
        
        /// <summary>
        /// Deletes a key of any type from storage in Azure Key Vault.
        /// </summary>
        public AzureKeyvaultKeyDeleteTask()
        {
            WithArguments("az keyvault key delete");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Id of the key.  If specified all other 'Id' arguments should be omitted.
        /// </summary>
        public AzureKeyvaultKeyDeleteTask Id(string id = null)
        {
            WithArguments("--id");
            if (!string.IsNullOrEmpty(id))
            {
                 WithArguments(id);
            }

            return this;
        }

        /// <summary>
        /// Name of the key. Required if --id is not specified.
        /// </summary>
        public AzureKeyvaultKeyDeleteTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Name of the key vault. Required if --id is not specified.
        /// </summary>
        public AzureKeyvaultKeyDeleteTask VaultName(string vaultName = null)
        {
            WithArguments("--vault-name");
            if (!string.IsNullOrEmpty(vaultName))
            {
                 WithArguments(vaultName);
            }

            return this;
        }
     }
}
