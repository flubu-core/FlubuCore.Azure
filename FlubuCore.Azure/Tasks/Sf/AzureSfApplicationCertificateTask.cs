
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfApplicationCertificateTask : ExternalProcessTaskBase<AzureSfApplicationCertificateTask>
     {
        
        /// <summary>
        /// Manage the certificate of an application.
        /// </summary>
        public AzureSfApplicationCertificateTask()
        {
            WithArguments("az sf application certificate");
        }

        protected override string Description { get; set; }
        
     }
}
