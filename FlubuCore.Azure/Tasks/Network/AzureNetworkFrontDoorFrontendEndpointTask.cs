
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorFrontendEndpointTask : ExternalProcessTaskBase<AzureNetworkFrontDoorFrontendEndpointTask>
     {
        
        /// <summary>
        /// Manage FrontDoor frontend endpoints.
        /// </summary>
        public AzureNetworkFrontDoorFrontendEndpointTask()
        {
            WithArguments("az network front-door frontend-endpoint");
        }

        protected override string Description { get; set; }
        
     }
}
