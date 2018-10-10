
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsEnrollmentTask : ExternalProcessTaskBase<AzureIotDpsEnrollmentTask>
     {
        
        /// <summary>
        /// Manage enrollments in an Azure IoT Hub Device Provisioning Service.
        /// </summary>
        public AzureIotDpsEnrollmentTask()
        {
            WithArguments("az iot dps enrollment");
        }

        protected override string Description { get; set; }
        
     }
}
