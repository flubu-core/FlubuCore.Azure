
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubDeviceTwinTask : ExternalProcessTaskBase<AzureIotHubDeviceTwinTask>
     {
        
        /// <summary>
        /// Manage IoT device twin configuration.
        /// </summary>
        public AzureIotHubDeviceTwinTask()
        {
            WithArguments("az iot hub device-twin");
        }

        protected override string Description { get; set; }
        
     }
}
