
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateIssuerTask : ExternalProcessTaskBase<AzureKeyvaultCertificateIssuerTask>
     {
        
        /// <summary>
        /// Manage certificate issuer information.
        /// </summary>
        public AzureKeyvaultCertificateIssuerTask()
        {
            WithArguments("az keyvault certificate issuer");
        }

        protected override string Description { get; set; }
        
     }
}
