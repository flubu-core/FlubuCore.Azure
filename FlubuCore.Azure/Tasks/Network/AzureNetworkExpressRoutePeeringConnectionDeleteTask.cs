
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRoutePeeringConnectionDeleteTask : ExternalProcessTaskBase<AzureNetworkExpressRoutePeeringConnectionDeleteTask>
     {
        
        /// <summary>
        /// Delete an ExpressRoute circuit connection.
        /// </summary>
        public AzureNetworkExpressRoutePeeringConnectionDeleteTask(string circuitName = null ,  string name = null ,  string peeringName = null ,  string resourceGroup = null)
        {
            WithArguments("az network express-route peering connection delete");
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

WithArguments("--peering-name");
            if (!string.IsNullOrEmpty(peeringName))
            {
                 WithArguments(peeringName);
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
