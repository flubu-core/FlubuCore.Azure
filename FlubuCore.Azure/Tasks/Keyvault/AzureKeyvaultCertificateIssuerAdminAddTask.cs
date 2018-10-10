
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateIssuerAdminAddTask : ExternalProcessTaskBase<AzureKeyvaultCertificateIssuerAdminAddTask>
     {
        
        /// <summary>
        /// Add admin details for a specified certificate issuer.
        /// </summary>
        public AzureKeyvaultCertificateIssuerAdminAddTask(string email = null ,  string issuerName = null ,  string vaultName = null)
        {
            WithArguments("az keyvault certificate issuer admin add");
WithArguments("--email");
            if (!string.IsNullOrEmpty(email))
            {
                 WithArguments(email);
            }

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
        
        public AzureKeyvaultCertificateIssuerAdminAddTask FirstName(string firstName = null)
        {
            WithArguments("--first-name");
            if (!string.IsNullOrEmpty(firstName))
            {
                 WithArguments(firstName);
            }

            return this;
        }

        public AzureKeyvaultCertificateIssuerAdminAddTask LastName(string lastName = null)
        {
            WithArguments("--last-name");
            if (!string.IsNullOrEmpty(lastName))
            {
                 WithArguments(lastName);
            }

            return this;
        }

        /// <summary>
        /// Amin phone number.
        /// </summary>
        public AzureKeyvaultCertificateIssuerAdminAddTask Phone(string phone = null)
        {
            WithArguments("--phone");
            if (!string.IsNullOrEmpty(phone))
            {
                 WithArguments(phone);
            }

            return this;
        }
     }
}
