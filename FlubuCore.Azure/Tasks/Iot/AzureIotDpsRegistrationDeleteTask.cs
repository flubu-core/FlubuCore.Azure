
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsRegistrationDeleteTask : ExternalProcessTaskBase<AzureIotDpsRegistrationDeleteTask>
     {
        
        /// <summary>
        /// Delete a device registration in an Azure IoT Hub Device Provisioning Service.
        /// </summary>
        public AzureIotDpsRegistrationDeleteTask(string dpsName = null ,  string registrationId = null ,  string resourceGroup = null)
        {
            WithArguments("az iot dps registration delete");
WithArguments("--dps-name");
            if (!string.IsNullOrEmpty(dpsName))
            {
                 WithArguments(dpsName);
            }

WithArguments("--registration-id");
            if (!string.IsNullOrEmpty(registrationId))
            {
                 WithArguments(registrationId);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
