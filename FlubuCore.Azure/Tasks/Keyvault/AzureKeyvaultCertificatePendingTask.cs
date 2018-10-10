
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultCertificatePendingTask : ExternalProcessTaskBase<AzureKeyvaultCertificatePendingTask>
     {
        
        /// <summary>
        /// Manage pending certificate creation operations.
        /// </summary>
        public AzureKeyvaultCertificatePendingTask()
        {
            WithArguments("az keyvault certificate pending");
        }

        protected override string Description { get; set; }
        
     }
}
