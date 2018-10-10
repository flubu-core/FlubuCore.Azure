
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsEnrollmentGroupTask : ExternalProcessTaskBase<AzureIotDpsEnrollmentGroupTask>
     {
        
        /// <summary>
        /// Manage Azure IoT Hub Device Provisioning Service.
        /// </summary>
        public AzureIotDpsEnrollmentGroupTask()
        {
            WithArguments("az iot dps enrollment-group");
        }

        protected override string Description { get; set; }
        
     }
}
