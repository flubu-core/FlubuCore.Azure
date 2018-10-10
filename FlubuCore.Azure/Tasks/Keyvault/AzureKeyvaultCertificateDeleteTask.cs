
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateDeleteTask : ExternalProcessTaskBase<AzureKeyvaultCertificateDeleteTask>
     {
        
        /// <summary>
        /// Deletes a certificate from a specified key vault.
        /// </summary>
        public AzureKeyvaultCertificateDeleteTask()
        {
            WithArguments("az keyvault certificate delete");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Id of the certificate.  If specified all other 'Id' arguments should be omitted.
        /// </summary>
        public AzureKeyvaultCertificateDeleteTask Id(string id = null)
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
        public AzureKeyvaultCertificateDeleteTask Name(string name = null)
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
        public AzureKeyvaultCertificateDeleteTask VaultName(string vaultName = null)
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
