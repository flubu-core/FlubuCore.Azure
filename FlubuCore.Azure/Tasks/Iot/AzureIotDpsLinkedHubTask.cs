
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsLinkedHubTask : ExternalProcessTaskBase<AzureIotDpsLinkedHubTask>
     {
        
        /// <summary>
        /// Manage Azure IoT Hub Device Provisioning Service linked IoT hubs.
        /// </summary>
        public AzureIotDpsLinkedHubTask()
        {
            WithArguments("az iot dps linked-hub");
        }

        protected override string Description { get; set; }
        
     }
}
