
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorProbeCreateTask : ExternalProcessTaskBase<AzureNetworkFrontDoorProbeCreateTask>
     {
        
        /// <summary>
        /// Create FrontDoor health probe settings.
        /// </summary>
        public AzureNetworkFrontDoorProbeCreateTask(string frontDoorName = null ,  string interval = null ,  string name = null ,  string path = null ,  string resourceGroup = null)
        {
            WithArguments("az network front-door probe create");
WithArguments("--front-door-name");
            if (!string.IsNullOrEmpty(frontDoorName))
            {
                 WithArguments(frontDoorName);
            }

WithArguments("--interval");
            if (!string.IsNullOrEmpty(interval))
            {
                 WithArguments(interval);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Protocol to use for sending probes.
        /// </summary>
        public AzureNetworkFrontDoorProbeCreateTask Protocol(string protocol = null)
        {
            WithArguments("--protocol");
            if (!string.IsNullOrEmpty(protocol))
            {
                 WithArguments(protocol);
            }

            return this;
        }
     }
}
