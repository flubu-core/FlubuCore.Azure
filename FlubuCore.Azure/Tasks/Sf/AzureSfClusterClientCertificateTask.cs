
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterClientCertificateTask : ExternalProcessTaskBase<AzureSfClusterClientCertificateTask>
     {
        
        /// <summary>
        /// Manage the client certificate of a cluster.
        /// </summary>
        public AzureSfClusterClientCertificateTask()
        {
            WithArguments("az sf cluster client-certificate");
        }

        protected override string Description { get; set; }
        
     }
}
