
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsRegistrationTask : ExternalProcessTaskBase<AzureIotDpsRegistrationTask>
     {
        
        /// <summary>
        /// Manage Azure IoT Hub Device Provisioning Service registrations.
        /// </summary>
        public AzureIotDpsRegistrationTask()
        {
            WithArguments("az iot dps registration");
        }

        protected override string Description { get; set; }
        
     }
}
