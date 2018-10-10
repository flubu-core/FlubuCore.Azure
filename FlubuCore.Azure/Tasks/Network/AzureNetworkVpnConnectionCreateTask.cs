
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnConnectionCreateTask : ExternalProcessTaskBase<AzureNetworkVpnConnectionCreateTask>
     {
        
        /// <summary>
        /// Create a VPN connection.
        /// </summary>
        public AzureNetworkVpnConnectionCreateTask(string name = null ,  string resourceGroup = null ,  string vnetGateway1 = null)
        {
            WithArguments("az network vpn-connection create");
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

WithArguments("--vnet-gateway1");
            if (!string.IsNullOrEmpty(vnetGateway1))
            {
                 WithArguments(vnetGateway1);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The authorization key for the VPN connection.
        /// </summary>
        public AzureNetworkVpnConnectionCreateTask AuthorizationKey(string authorizationKey = null)
        {
            WithArguments("--authorization-key");
            if (!string.IsNullOrEmpty(authorizationKey))
            {
                 WithArguments(authorizationKey);
            }

            return this;
        }

        /// <summary>
        /// Enable BGP for this VPN connection.
        /// </summary>
        public AzureNetworkVpnConnectionCreateTask EnableBgp(string enableBgp = null)
        {
            WithArguments("--enable-bgp");
            if (!string.IsNullOrEmpty(enableBgp))
            {
                 WithArguments(enableBgp);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkVpnConnectionCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Connection routing weight.
        /// </summary>
        public AzureNetworkVpnConnectionCreateTask RoutingWeight(string routingWeight = null)
        {
            WithArguments("--routing-weight");
            if (!string.IsNullOrEmpty(routingWeight))
            {
                 WithArguments(routingWeight);
            }

            return this;
        }

        /// <summary>
        /// Shared IPSec key.
        /// </summary>
        public AzureNetworkVpnConnectionCreateTask SharedKey(string sharedKey = null)
        {
            WithArguments("--shared-key");
            if (!string.IsNullOrEmpty(sharedKey))
            {
                 WithArguments(sharedKey);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkVpnConnectionCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Enable policy-based traffic selectors.
        /// </summary>
        public AzureNetworkVpnConnectionCreateTask UsePolicyBasedTrafficSelectors(string usePolicyBasedTrafficSelectors = null)
        {
            WithArguments("--use-policy-based-traffic-selectors");
            if (!string.IsNullOrEmpty(usePolicyBasedTrafficSelectors))
            {
                 WithArguments(usePolicyBasedTrafficSelectors);
            }

            return this;
        }

        /// <summary>
        /// Display and validate the ARM template but do not create any resources.
        /// </summary>
        public AzureNetworkVpnConnectionCreateTask Validate(string validate = null)
        {
            WithArguments("--validate");
            if (!string.IsNullOrEmpty(validate))
            {
                 WithArguments(validate);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the destination ExpressRoute to connect to using an 'ExpressRoute' connection.
        /// </summary>
        public AzureNetworkVpnConnectionCreateTask ExpressRouteCircuit2(string expressRouteCircuit2 = null)
        {
            WithArguments("--express-route-circuit2");
            if (!string.IsNullOrEmpty(expressRouteCircuit2))
            {
                 WithArguments(expressRouteCircuit2);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the destination local network gateway to connect to using an 'IPSec' connection.
        /// </summary>
        public AzureNetworkVpnConnectionCreateTask LocalGateway2(string localGateway2 = null)
        {
            WithArguments("--local-gateway2");
            if (!string.IsNullOrEmpty(localGateway2))
            {
                 WithArguments(localGateway2);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the destination virtual network gateway to connect to using a 'Vnet2Vnet' connection.
        /// </summary>
        public AzureNetworkVpnConnectionCreateTask VnetGateway2(string vnetGateway2 = null)
        {
            WithArguments("--vnet-gateway2");
            if (!string.IsNullOrEmpty(vnetGateway2))
            {
                 WithArguments(vnetGateway2);
            }

            return this;
        }
     }
}
