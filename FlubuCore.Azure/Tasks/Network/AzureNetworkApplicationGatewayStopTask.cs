
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayStopTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayStopTask>
     {
        
        /// <summary>
        /// Stop an application gateway.
        /// </summary>
        public AzureNetworkApplicationGatewayStopTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway stop");
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
