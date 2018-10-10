
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateIssuerAdminTask : ExternalProcessTaskBase<AzureKeyvaultCertificateIssuerAdminTask>
     {
        
        /// <summary>
        /// Manage admin information for certificate issuers.
        /// </summary>
        public AzureKeyvaultCertificateIssuerAdminTask()
        {
            WithArguments("az keyvault certificate issuer admin");
        }

        protected override string Description { get; set; }
        
     }
}
