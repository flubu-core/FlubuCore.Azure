
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateContactDeleteTask : ExternalProcessTaskBase<AzureKeyvaultCertificateContactDeleteTask>
     {
        
        /// <summary>
        /// Remove a certificate contact from the specified vault.
        /// </summary>
        public AzureKeyvaultCertificateContactDeleteTask(string email = null ,  string vaultName = null)
        {
            WithArguments("az keyvault certificate contact delete");
WithArguments("--email");
            if (!string.IsNullOrEmpty(email))
            {
                 WithArguments(email);
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
