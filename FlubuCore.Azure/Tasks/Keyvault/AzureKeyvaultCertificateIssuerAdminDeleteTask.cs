
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateIssuerAdminDeleteTask : ExternalProcessTaskBase<AzureKeyvaultCertificateIssuerAdminDeleteTask>
     {
        
        /// <summary>
        /// Remove admin details for the specified certificate issuer.
        /// </summary>
        public AzureKeyvaultCertificateIssuerAdminDeleteTask(string email = null ,  string issuerName = null ,  string vaultName = null)
        {
            WithArguments("az keyvault certificate issuer admin delete");
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
        
     }
}
