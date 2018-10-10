
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateContactTask : ExternalProcessTaskBase<AzureKeyvaultCertificateContactTask>
     {
        
        /// <summary>
        /// Manage contacts for certificate management.
        /// </summary>
        public AzureKeyvaultCertificateContactTask()
        {
            WithArguments("az keyvault certificate contact");
        }

        protected override string Description { get; set; }
        
     }
}
