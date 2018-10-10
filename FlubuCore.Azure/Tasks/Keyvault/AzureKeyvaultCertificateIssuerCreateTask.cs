
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateIssuerCreateTask : ExternalProcessTaskBase<AzureKeyvaultCertificateIssuerCreateTask>
     {
        
        /// <summary>
        /// Create a certificate issuer record.
        /// </summary>
        public AzureKeyvaultCertificateIssuerCreateTask(string issuerName = null ,  string providerName = null ,  string vaultName = null)
        {
            WithArguments("az keyvault certificate issuer create");
WithArguments("--issuer-name");
            if (!string.IsNullOrEmpty(issuerName))
            {
                 WithArguments(issuerName);
            }

WithArguments("--provider-name");
            if (!string.IsNullOrEmpty(providerName))
            {
                 WithArguments(providerName);
            }

WithArguments("--vault-name");
            if (!string.IsNullOrEmpty(vaultName))
            {
                 WithArguments(vaultName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Set issuer to disabled state.
        /// </summary>
        public AzureKeyvaultCertificateIssuerCreateTask Disabled(string disabled = null)
        {
            WithArguments("--disabled");
            if (!string.IsNullOrEmpty(disabled))
            {
                 WithArguments(disabled);
            }

            return this;
        }

        /// <summary>
        /// The issuer account id/username/etc.
        /// </summary>
        public AzureKeyvaultCertificateIssuerCreateTask AccountId(string accountId = null)
        {
            WithArguments("--account-id");
            if (!string.IsNullOrEmpty(accountId))
            {
                 WithArguments(accountId);
            }

            return this;
        }

        /// <summary>
        /// The issuer account password/secret/etc.
        /// </summary>
        public AzureKeyvaultCertificateIssuerCreateTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// The organization id.
        /// </summary>
        public AzureKeyvaultCertificateIssuerCreateTask OrganizationId(string organizationId = null)
        {
            WithArguments("--organization-id");
            if (!string.IsNullOrEmpty(organizationId))
            {
                 WithArguments(organizationId);
            }

            return this;
        }
     }
}
