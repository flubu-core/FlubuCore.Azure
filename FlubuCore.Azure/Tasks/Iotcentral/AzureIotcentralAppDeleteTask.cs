
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iotcentral
{
     public partial class AzureIotcentralAppDeleteTask : ExternalProcessTaskBase<AzureIotcentralAppDeleteTask>
     {
        
        /// <summary>
        /// Delete an IoT Central application.
        /// </summary>
        public AzureIotcentralAppDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az iotcentral app delete");
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
