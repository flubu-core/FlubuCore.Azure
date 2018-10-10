
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateIssuerUpdateTask : ExternalProcessTaskBase<AzureKeyvaultCertificateIssuerUpdateTask>
     {
        
        /// <summary>
        /// Update a certificate issuer record.
        /// </summary>
        public AzureKeyvaultCertificateIssuerUpdateTask(string issuerName = null ,  string vaultName = null)
        {
            WithArguments("az keyvault certificate issuer update");
WithArguments("--issuer-name");
            if (!string.IsNullOrEmpty(issuerName))
            {
                 WithArguments(issuerName);
            }

WithArguments("--vault-name");
            if (!string.IsNullOrEmpty(vaultName))
            {
                 WithArguments(vaultName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Set issuer enabled state.
        /// </summary>
        public AzureKeyvaultCertificateIssuerUpdateTask Enabled(string enabled = null)
        {
            WithArguments("--enabled");
            if (!string.IsNullOrEmpty(enabled))
            {
                 WithArguments(enabled);
            }

            return this;
        }

        /// <summary>
        /// The certificate provider name. Must be registered with your tenant ID and in your region.
        /// </summary>
        public AzureKeyvaultCertificateIssuerUpdateTask ProviderName(string providerName = null)
        {
            WithArguments("--provider-name");
            if (!string.IsNullOrEmpty(providerName))
            {
                 WithArguments(providerName);
            }

            return this;
        }

        /// <summary>
        /// The issuer account id/username/etc.
        /// </summary>
        public AzureKeyvaultCertificateIssuerUpdateTask AccountId(string accountId = null)
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
        public AzureKeyvaultCertificateIssuerUpdateTask Password(string password = null)
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
        public AzureKeyvaultCertificateIssuerUpdateTask OrganizationId(string organizationId = null)
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
