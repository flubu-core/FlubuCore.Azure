
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterCertificateTask : ExternalProcessTaskBase<AzureSfClusterCertificateTask>
     {
        
        /// <summary>
        /// Manage a cluster certificate.
        /// </summary>
        public AzureSfClusterCertificateTask()
        {
            WithArguments("az sf cluster certificate");
        }

        protected override string Description { get; set; }
        
     }
}
