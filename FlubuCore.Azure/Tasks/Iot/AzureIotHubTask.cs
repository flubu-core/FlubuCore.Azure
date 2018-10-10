
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubTask : ExternalProcessTaskBase<AzureIotHubTask>
     {
        
        /// <summary>
        /// Manage entities in an Azure IoT Hub.
        /// </summary>
        public AzureIotHubTask()
        {
            WithArguments("az iot hub");
        }

        protected override string Description { get; set; }
        
     }
}
