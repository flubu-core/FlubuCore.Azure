
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorProbeTask : ExternalProcessTaskBase<AzureNetworkFrontDoorProbeTask>
     {
        
        /// <summary>
        /// Manage FrontDoor health probe settings.
        /// </summary>
        public AzureNetworkFrontDoorProbeTask()
        {
            WithArguments("az network front-door probe");
        }

        protected override string Description { get; set; }
        
     }
}
