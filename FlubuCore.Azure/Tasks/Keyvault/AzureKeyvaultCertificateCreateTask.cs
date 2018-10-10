
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateCreateTask : ExternalProcessTaskBase<AzureKeyvaultCertificateCreateTask>
     {
        
        /// <summary>
        /// Create a Key Vault certificate.
        /// </summary>
        public AzureKeyvaultCertificateCreateTask(string policy = null ,  string name = null ,  string vaultName = null)
        {
            WithArguments("az keyvault certificate create");
WithArguments("--policy");
            if (!string.IsNullOrEmpty(policy))
            {
                 WithArguments(policy);
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
        public AzureKeyvaultCertificateCreateTask Disabled(string disabled = null)
        {
            WithArguments("--disabled");
            if (!string.IsNullOrEmpty(disabled))
            {
                 WithArguments(disabled);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureKeyvaultCertificateCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Number of months the certificate is valid for. Overrides the value specified with --policy/-p.
        /// </summary>
        public AzureKeyvaultCertificateCreateTask Validity(string validity = null)
        {
            WithArguments("--validity");
            if (!string.IsNullOrEmpty(validity))
            {
                 WithArguments(validity);
            }

            return this;
        }
     }
}
