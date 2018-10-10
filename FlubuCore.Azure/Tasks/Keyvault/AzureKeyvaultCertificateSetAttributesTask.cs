
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateSetAttributesTask : ExternalProcessTaskBase<AzureKeyvaultCertificateSetAttributesTask>
     {
        
        /// <summary>
        /// Updates the specified attributes associated with the given certificate.
        /// </summary>
        public AzureKeyvaultCertificateSetAttributesTask()
        {
            WithArguments("az keyvault certificate set-attributes");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Enable the certificate.
        /// </summary>
        public AzureKeyvaultCertificateSetAttributesTask Enabled(string enabled = null)
        {
            WithArguments("--enabled");
            if (!string.IsNullOrEmpty(enabled))
            {
                 WithArguments(enabled);
            }

            return this;
        }

        /// <summary>
        /// JSON encoded policy defintion. Use @{file} to load from a file.
        /// </summary>
        public AzureKeyvaultCertificateSetAttributesTask Policy(string policy = null)
        {
            WithArguments("--policy");
            if (!string.IsNullOrEmpty(policy))
            {
                 WithArguments(policy);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureKeyvaultCertificateSetAttributesTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Id of the certificate.  If specified all other 'Id' arguments should be omitted.
        /// </summary>
        public AzureKeyvaultCertificateSetAttributesTask Id(string id = null)
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
        public AzureKeyvaultCertificateSetAttributesTask Name(string name = null)
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
        public AzureKeyvaultCertificateSetAttributesTask VaultName(string vaultName = null)
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
        public AzureKeyvaultCertificateSetAttributesTask Version(string version = null)
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
