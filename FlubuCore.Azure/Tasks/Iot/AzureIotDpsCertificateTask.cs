
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsCertificateTask : ExternalProcessTaskBase<AzureIotDpsCertificateTask>
     {
        
        /// <summary>
        /// Manage Azure IoT Hub Device Provisioning Service certificates.
        /// </summary>
        public AzureIotDpsCertificateTask()
        {
            WithArguments("az iot dps certificate");
        }

        protected override string Description { get; set; }
        
     }
}
