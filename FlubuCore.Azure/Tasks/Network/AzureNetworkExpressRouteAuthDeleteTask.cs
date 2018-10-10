
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRouteAuthDeleteTask : ExternalProcessTaskBase<AzureNetworkExpressRouteAuthDeleteTask>
     {
        
        /// <summary>
        /// Delete a link authorization of an ExpressRoute circuit.
        /// </summary>
        public AzureNetworkExpressRouteAuthDeleteTask(string circuitName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network express-route auth delete");
WithArguments("--circuit-name");
            if (!string.IsNullOrEmpty(circuitName))
            {
                 WithArguments(circuitName);
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
