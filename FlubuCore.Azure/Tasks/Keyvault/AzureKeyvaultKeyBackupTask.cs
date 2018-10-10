
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultKeyBackupTask : ExternalProcessTaskBase<AzureKeyvaultKeyBackupTask>
     {
        
        /// <summary>
        /// Requests that a backup of the specified key be downloaded to the client.
        /// </summary>
        public AzureKeyvaultKeyBackupTask(string file = null)
        {
            WithArguments("az keyvault key backup");
WithArguments("--file");
            if (!string.IsNullOrEmpty(file))
            {
                 WithArguments(file);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Id of the key.  If specified all other 'Id' arguments should be omitted.
        /// </summary>
        public AzureKeyvaultKeyBackupTask Id(string id = null)
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
        public AzureKeyvaultKeyBackupTask Name(string name = null)
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
        public AzureKeyvaultKeyBackupTask VaultName(string vaultName = null)
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
