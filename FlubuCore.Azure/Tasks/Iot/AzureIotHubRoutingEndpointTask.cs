
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubRoutingEndpointTask : ExternalProcessTaskBase<AzureIotHubRoutingEndpointTask>
     {
        
        /// <summary>
        /// Manage custom endpoints of an IoT hub.
        /// </summary>
        public AzureIotHubRoutingEndpointTask()
        {
            WithArguments("az iot hub routing-endpoint");
        }

        protected override string Description { get; set; }
        
     }
}
