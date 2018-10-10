
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDeviceTask : ExternalProcessTaskBase<AzureIotDeviceTask>
     {
        
        /// <summary>
        /// Leverage device-to-cloud and cloud-to-device messaging capabilities.
        /// </summary>
        public AzureIotDeviceTask()
        {
            WithArguments("az iot device");
        }

        protected override string Description { get; set; }
        
     }
}
