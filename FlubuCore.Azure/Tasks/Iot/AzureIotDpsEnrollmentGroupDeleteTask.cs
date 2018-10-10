
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsEnrollmentGroupDeleteTask : ExternalProcessTaskBase<AzureIotDpsEnrollmentGroupDeleteTask>
     {
        
        /// <summary>
        /// Delete an enrollment group in an Azure IoT Hub Device Provisioning Service.
        /// </summary>
        public AzureIotDpsEnrollmentGroupDeleteTask(string dpsName = null ,  string enrollmentId = null ,  string resourceGroup = null)
        {
            WithArguments("az iot dps enrollment-group delete");
WithArguments("--dps-name");
            if (!string.IsNullOrEmpty(dpsName))
            {
                 WithArguments(dpsName);
            }

WithArguments("--enrollment-id");
            if (!string.IsNullOrEmpty(enrollmentId))
            {
                 WithArguments(enrollmentId);
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
