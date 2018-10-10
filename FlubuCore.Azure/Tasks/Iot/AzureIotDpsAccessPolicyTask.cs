
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsAccessPolicyTask : ExternalProcessTaskBase<AzureIotDpsAccessPolicyTask>
     {
        
        /// <summary>
        /// Manage Azure IoT Hub Device Provisioning Service access policies.
        /// </summary>
        public AzureIotDpsAccessPolicyTask()
        {
            WithArguments("az iot dps access-policy");
        }

        protected override string Description { get; set; }
        
     }
}
