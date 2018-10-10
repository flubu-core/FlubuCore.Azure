
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorProbeDeleteTask : ExternalProcessTaskBase<AzureNetworkFrontDoorProbeDeleteTask>
     {
        
        /// <summary>
        /// Delete FrontDoor health probe settings.
        /// </summary>
        public AzureNetworkFrontDoorProbeDeleteTask(string frontDoorName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network front-door probe delete");
WithArguments("--front-door-name");
            if (!string.IsNullOrEmpty(frontDoorName))
            {
                 WithArguments(frontDoorName);
            }

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
