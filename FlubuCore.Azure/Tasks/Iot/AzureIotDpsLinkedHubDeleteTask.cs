
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsLinkedHubDeleteTask : ExternalProcessTaskBase<AzureIotDpsLinkedHubDeleteTask>
     {
        
        /// <summary>
        /// Update a linked IoT hub in an Azure IoT Hub device provisioning service.
        /// </summary>
        public AzureIotDpsLinkedHubDeleteTask(string dpsName = null ,  string linkedHub = null ,  string resourceGroup = null)
        {
            WithArguments("az iot dps linked-hub delete");
WithArguments("--dps-name");
            if (!string.IsNullOrEmpty(dpsName))
            {
                 WithArguments(dpsName);
            }

WithArguments("--linked-hub");
            if (!string.IsNullOrEmpty(linkedHub))
            {
                 WithArguments(linkedHub);
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
        public AzureIotDpsLinkedHubDeleteTask NoWait(string noWait = null)
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
