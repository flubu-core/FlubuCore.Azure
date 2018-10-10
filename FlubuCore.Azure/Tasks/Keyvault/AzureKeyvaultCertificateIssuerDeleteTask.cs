
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateIssuerDeleteTask : ExternalProcessTaskBase<AzureKeyvaultCertificateIssuerDeleteTask>
     {
        
        /// <summary>
        /// Deletes the specified certificate issuer.
        /// </summary>
        public AzureKeyvaultCertificateIssuerDeleteTask(string issuerName = null ,  string vaultName = null)
        {
            WithArguments("az keyvault certificate issuer delete");
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
