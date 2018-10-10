
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultSecretDeleteTask : ExternalProcessTaskBase<AzureKeyvaultSecretDeleteTask>
     {
        
        /// <summary>
        /// Deletes a secret from a specified key vault.
        /// </summary>
        public AzureKeyvaultSecretDeleteTask()
        {
            WithArguments("az keyvault secret delete");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Id of the secret.  If specified all other 'Id' arguments should be omitted.
        /// </summary>
        public AzureKeyvaultSecretDeleteTask Id(string id = null)
        {
            WithArguments("--id");
            if (!string.IsNullOrEmpty(id))
            {
                 WithArguments(id);
            }

            return this;
        }

        /// <summary>
        /// Name of the secret. Required if --id is not specified.
        /// </summary>
        public AzureKeyvaultSecretDeleteTask Name(string name = null)
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
        public AzureKeyvaultSecretDeleteTask VaultName(string vaultName = null)
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
