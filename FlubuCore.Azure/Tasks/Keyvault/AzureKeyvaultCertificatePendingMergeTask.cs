
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificatePendingMergeTask : ExternalProcessTaskBase<AzureKeyvaultCertificatePendingMergeTask>
     {
        
        /// <summary>
        /// Merges a certificate or a certificate chain with a key pair existing on the server.
        /// </summary>
        public AzureKeyvaultCertificatePendingMergeTask(string file = null ,  string name = null ,  string vaultName = null)
        {
            WithArguments("az keyvault certificate pending merge");
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
        /// Create certificate in disabled state.
        /// </summary>
        public AzureKeyvaultCertificatePendingMergeTask Disabled(string disabled = null)
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
        public AzureKeyvaultCertificatePendingMergeTask Expires(string expires = null)
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
        public AzureKeyvaultCertificatePendingMergeTask NotBefore(string notBefore = null)
        {
            WithArguments("--not-before");
            if (!string.IsNullOrEmpty(notBefore))
            {
                 WithArguments(notBefore);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureKeyvaultCertificatePendingMergeTask Tags(string tags = null)
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
