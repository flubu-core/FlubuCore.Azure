
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchCertificateTask : ExternalProcessTaskBase<AzureBatchCertificateTask>
     {
        
        /// <summary>
        /// Manage Batch certificates.
        /// </summary>
        public AzureBatchCertificateTask()
        {
            WithArguments("az batch certificate");
        }

        protected override string Description { get; set; }
        
     }
}
