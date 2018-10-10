
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsTask : ExternalProcessTaskBase<AzureIotDpsTask>
     {
        
        /// <summary>
        /// Manage entities in an Azure IoT Hub Device Provisioning Service. Augmented with the IoT extension.
        /// </summary>
        public AzureIotDpsTask()
        {
            WithArguments("az iot dps");
        }

        protected override string Description { get; set; }
        
     }
}
