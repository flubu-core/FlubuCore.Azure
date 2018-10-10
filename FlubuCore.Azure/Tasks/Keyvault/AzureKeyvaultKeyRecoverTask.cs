
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultKeyRecoverTask : ExternalProcessTaskBase<AzureKeyvaultKeyRecoverTask>
     {
        
        /// <summary>
        /// Recovers the deleted key to its latest version.
        /// </summary>
        public AzureKeyvaultKeyRecoverTask()
        {
            WithArguments("az keyvault key recover");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The recovery id of the key.  If specified all other 'Id' arguments should be omitted.
        /// </summary>
        public AzureKeyvaultKeyRecoverTask Id(string id = null)
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
        public AzureKeyvaultKeyRecoverTask Name(string name = null)
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
        public AzureKeyvaultKeyRecoverTask VaultName(string vaultName = null)
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
