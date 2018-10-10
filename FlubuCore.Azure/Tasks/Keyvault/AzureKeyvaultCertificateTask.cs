
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificateTask : ExternalProcessTaskBase<AzureKeyvaultCertificateTask>
     {
        
        /// <summary>
        /// Manage certificates.
        /// </summary>
        public AzureKeyvaultCertificateTask()
        {
            WithArguments("az keyvault certificate");
        }

        protected override string Description { get; set; }
        
     }
}
