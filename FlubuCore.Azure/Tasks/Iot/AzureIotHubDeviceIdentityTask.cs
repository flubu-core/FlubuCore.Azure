
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubDeviceIdentityTask : ExternalProcessTaskBase<AzureIotHubDeviceIdentityTask>
     {
        
        /// <summary>
        /// Manage IoT devices.
        /// </summary>
        public AzureIotHubDeviceIdentityTask()
        {
            WithArguments("az iot hub device-identity");
        }

        protected override string Description { get; set; }
        
     }
}
