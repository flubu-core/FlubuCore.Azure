
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkInterfaceEndpointTask : ExternalProcessTaskBase<AzureNetworkInterfaceEndpointTask>
     {
        
        /// <summary>
        /// Manage interface endpoints.
        /// </summary>
        public AzureNetworkInterfaceEndpointTask()
        {
            WithArguments("az network interface-endpoint");
        }

        protected override string Description { get; set; }
        
     }
}
