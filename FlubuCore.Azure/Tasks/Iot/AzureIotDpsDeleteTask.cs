
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsDeleteTask : ExternalProcessTaskBase<AzureIotDpsDeleteTask>
     {
        
        /// <summary>
        /// Delete an Azure IoT Hub device provisioning service.
        /// </summary>
        public AzureIotDpsDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az iot dps delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
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
