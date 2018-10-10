
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultKeyImportTask : ExternalProcessTaskBase<AzureKeyvaultKeyImportTask>
     {
        
        /// <summary>
        /// Import a private key.
        /// </summary>
        public AzureKeyvaultKeyImportTask(string name = null ,  string vaultName = null)
        {
            WithArguments("az keyvault key import");
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
        /// Create key in disabled state.
        /// </summary>
        public AzureKeyvaultKeyImportTask Disabled(string disabled = null)
        {
            WithArguments("--disabled");
            if (!string.IsNullOrEmpty(disabled))
            {
                 WithArguments(disabled);
            }

            return this;
        }

        /// <summary>
        /// Expiration UTC datetime  (Y-m-d'T'H:M:S'Z').
        /// </summary>
        public AzureKeyvaultKeyImportTask Expires(string expires = null)
        {
            WithArguments("--expires");
            if (!string.IsNullOrEmpty(expires))
            {
                 WithArguments(expires);
            }

            return this;
        }

        /// <summary>
        /// Key not usable before the provided UTC datetime  (Y-m-d'T'H:M:S'Z').
        /// </summary>
        public AzureKeyvaultKeyImportTask NotBefore(string notBefore = null)
        {
            WithArguments("--not-before");
            if (!string.IsNullOrEmpty(notBefore))
            {
                 WithArguments(notBefore);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of permitted JSON web key operations.
        /// </summary>
        public AzureKeyvaultKeyImportTask Ops(string ops = null)
        {
            WithArguments("--ops");
            if (!string.IsNullOrEmpty(ops))
            {
                 WithArguments(ops);
            }

            return this;
        }

        /// <summary>
        /// Specifies the type of key protection.
        /// </summary>
        public AzureKeyvaultKeyImportTask Protection(string protection = null)
        {
            WithArguments("--protection");
            if (!string.IsNullOrEmpty(protection))
            {
                 WithArguments(protection);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureKeyvaultKeyImportTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// BYOK file containing the key to be imported. Must not be password protected.
        /// </summary>
        public AzureKeyvaultKeyImportTask ByokFile(string byokFile = null)
        {
            WithArguments("--byok-file");
            if (!string.IsNullOrEmpty(byokFile))
            {
                 WithArguments(byokFile);
            }

            return this;
        }

        /// <summary>
        /// PEM file containing the key to be imported.
        /// </summary>
        public AzureKeyvaultKeyImportTask PemFile(string pemFile = null)
        {
            WithArguments("--pem-file");
            if (!string.IsNullOrEmpty(pemFile))
            {
                 WithArguments(pemFile);
            }

            return this;
        }

        /// <summary>
        /// Password of PEM file.
        /// </summary>
        public AzureKeyvaultKeyImportTask PemPassword(string pemPassword = null)
        {
            WithArguments("--pem-password");
            if (!string.IsNullOrEmpty(pemPassword))
            {
                 WithArguments(pemPassword);
            }

            return this;
        }
     }
}
