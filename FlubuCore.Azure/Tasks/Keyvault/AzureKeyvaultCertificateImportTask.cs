
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateImportTask : ExternalProcessTaskBase<AzureKeyvaultCertificateImportTask>
     {
        
        /// <summary>
        /// Import a certificate into KeyVault.
        /// </summary>
        public AzureKeyvaultCertificateImportTask(string file = null ,  string name = null ,  string vaultName = null)
        {
            WithArguments("az keyvault certificate import");
WithArguments("--file");
            if (!string.IsNullOrEmpty(file))
            {
                 WithArguments(file);
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
        
        /// <summary>
        /// Import the certificate in disabled state.
        /// </summary>
        public AzureKeyvaultCertificateImportTask Disabled(string disabled = null)
        {
            WithArguments("--disabled");
            if (!string.IsNullOrEmpty(disabled))
            {
                 WithArguments(disabled);
            }

            return this;
        }

        /// <summary>
        /// If the private key in certificate is encrypted, the password used for encryption.
        /// </summary>
        public AzureKeyvaultCertificateImportTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// JSON encoded policy defintion. Use @{file} to load from a file.
        /// </summary>
        public AzureKeyvaultCertificateImportTask Policy(string policy = null)
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
        public AzureKeyvaultCertificateImportTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }
     }
}
