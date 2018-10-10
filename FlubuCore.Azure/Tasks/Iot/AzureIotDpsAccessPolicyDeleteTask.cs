
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsAccessPolicyDeleteTask : ExternalProcessTaskBase<AzureIotDpsAccessPolicyDeleteTask>
     {
        
        /// <summary>
        /// Delete a shared access policies in an Azure IoT Hub device provisioning service.
        /// </summary>
        public AzureIotDpsAccessPolicyDeleteTask(string accessPolicyName = null ,  string dpsName = null ,  string resourceGroup = null)
        {
            WithArguments("az iot dps access-policy delete");
WithArguments("--access-policy-name");
            if (!string.IsNullOrEmpty(accessPolicyName))
            {
                 WithArguments(accessPolicyName);
            }

WithArguments("--dps-name");
            if (!string.IsNullOrEmpty(dpsName))
            {
                 WithArguments(dpsName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureIotDpsAccessPolicyDeleteTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }
     }
}
