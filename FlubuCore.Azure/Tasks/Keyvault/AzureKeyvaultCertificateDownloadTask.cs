
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateDownloadTask : ExternalProcessTaskBase<AzureKeyvaultCertificateDownloadTask>
     {
        
        /// <summary>
        /// Download the public portion of a Key Vault certificate.
        /// </summary>
        public AzureKeyvaultCertificateDownloadTask(string file = null)
        {
            WithArguments("az keyvault certificate download");
WithArguments("--file");
            if (!string.IsNullOrEmpty(file))
            {
                 WithArguments(file);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Encoding of the certificate. DER will create a binary DER formatted x509 certificate, and PEM will create a base64 PEM x509 certificate.
        /// </summary>
        public AzureKeyvaultCertificateDownloadTask Encoding(string encoding = null)
        {
            WithArguments("--encoding");
            if (!string.IsNullOrEmpty(encoding))
            {
                 WithArguments(encoding);
            }

            return this;
        }

        /// <summary>
        /// Id of the certificate.  If specified all other 'Id' arguments should be omitted.
        /// </summary>
        public AzureKeyvaultCertificateDownloadTask Id(string id = null)
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
        public AzureKeyvaultCertificateDownloadTask Name(string name = null)
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
        public AzureKeyvaultCertificateDownloadTask VaultName(string vaultName = null)
        {
            WithArguments("--vault-name");
            if (!string.IsNullOrEmpty(vaultName))
            {
                 WithArguments(vaultName);
            }

            return this;
        }

        /// <summary>
        /// The certificate version. If omitted, uses the latest version.
        /// </summary>
        public AzureKeyvaultCertificateDownloadTask Version(string version = null)
        {
            WithArguments("--version");
            if (!string.IsNullOrEmpty(version))
            {
                 WithArguments(version);
            }

            return this;
        }
     }
}
