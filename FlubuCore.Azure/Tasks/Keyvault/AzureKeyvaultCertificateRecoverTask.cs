
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateRecoverTask : ExternalProcessTaskBase<AzureKeyvaultCertificateRecoverTask>
     {
        
        /// <summary>
        /// Recovers the deleted certificate back to its current version under /certificates.
        /// </summary>
        public AzureKeyvaultCertificateRecoverTask()
        {
            WithArguments("az keyvault certificate recover");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The recovery id of the certificate.  If specified all other 'Id' arguments should be omitted.
        /// </summary>
        public AzureKeyvaultCertificateRecoverTask Id(string id = null)
        {
            WithArguments("--id");
            if (!string.IsNullOrEmpty(id))
            {
                 WithArguments(id);
            }

            return this;
        }

        /// <summary>
        /// Name of the certificate. Required if --id is not specified.
        /// </summary>
        public AzureKeyvaultCertificateRecoverTask Name(string name = null)
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
        public AzureKeyvaultCertificateRecoverTask VaultName(string vaultName = null)
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
