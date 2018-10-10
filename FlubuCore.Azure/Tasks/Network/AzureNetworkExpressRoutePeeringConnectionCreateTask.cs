
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRoutePeeringConnectionCreateTask : ExternalProcessTaskBase<AzureNetworkExpressRoutePeeringConnectionCreateTask>
     {
        
        /// <summary>
        /// Create connections between two ExpressRoute circuits.
        /// </summary>
        public AzureNetworkExpressRoutePeeringConnectionCreateTask(string addressPrefix = null ,  string circuitName = null ,  string name = null ,  string peerCircuit = null ,  string peeringName = null ,  string resourceGroup = null)
        {
            WithArguments("az network express-route peering connection create");
WithArguments("--address-prefix");
            if (!string.IsNullOrEmpty(addressPrefix))
            {
                 WithArguments(addressPrefix);
            }

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

WithArguments("--peer-circuit");
            if (!string.IsNullOrEmpty(peerCircuit))
            {
                 WithArguments(peerCircuit);
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
        
        /// <summary>
        /// The authorization key used when the peer circuit is in another subscription.
        /// </summary>
        public AzureNetworkExpressRoutePeeringConnectionCreateTask AuthorizationKey(string authorizationKey = null)
        {
            WithArguments("--authorization-key");
            if (!string.IsNullOrEmpty(authorizationKey))
            {
                 WithArguments(authorizationKey);
            }

            return this;
        }
     }
}
