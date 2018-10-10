
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultSecretBackupTask : ExternalProcessTaskBase<AzureKeyvaultSecretBackupTask>
     {
        
        /// <summary>
        /// Backs up the specified secret.
        /// </summary>
        public AzureKeyvaultSecretBackupTask(string filePath = null)
        {
            WithArguments("az keyvault secret backup");
WithArguments("--file-path");
            if (!string.IsNullOrEmpty(filePath))
            {
                 WithArguments(filePath);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Id of the secret.  If specified all other 'Id' arguments should be omitted.
        /// </summary>
        public AzureKeyvaultSecretBackupTask Id(string id = null)
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
        public AzureKeyvaultSecretBackupTask Name(string name = null)
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
        public AzureKeyvaultSecretBackupTask VaultName(string vaultName = null)
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
