
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorTask : ExternalProcessTaskBase<AzureNetworkFrontDoorTask>
     {
        
        /// <summary>
        /// Manage FrontDoors.
        /// </summary>
        public AzureNetworkFrontDoorTask()
        {
            WithArguments("az network front-door");
        }

        protected override string Description { get; set; }
        
     }
}
