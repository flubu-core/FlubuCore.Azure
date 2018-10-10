
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubCertificateTask : ExternalProcessTaskBase<AzureIotHubCertificateTask>
     {
        
        /// <summary>
        /// Manage IoT Hub certificates.
        /// </summary>
        public AzureIotHubCertificateTask()
        {
            WithArguments("az iot hub certificate");
        }

        protected override string Description { get; set; }
        
     }
}
