
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetGatewayCreateTask : ExternalProcessTaskBase<AzureNetworkVnetGatewayCreateTask>
     {
        
        /// <summary>
        /// Create a virtual network gateway.
        /// </summary>
        public AzureNetworkVnetGatewayCreateTask(string name = null ,  string publicIpAddresses = null ,  string resourceGroup = null ,  string vnet = null)
        {
            WithArguments("az network vnet-gateway create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--public-ip-addresses");
            if (!string.IsNullOrEmpty(publicIpAddresses))
            {
                 WithArguments(publicIpAddresses);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--vnet");
            if (!string.IsNullOrEmpty(vnet))
            {
                 WithArguments(vnet);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The gateway type.
        /// </summary>
        public AzureNetworkVnetGatewayCreateTask GatewayType(string gatewayType = null)
        {
            WithArguments("--gateway-type");
            if (!string.IsNullOrEmpty(gatewayType))
            {
                 WithArguments(gatewayType);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkVnetGatewayCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkVnetGatewayCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// VNet gateway SKU.
        /// </summary>
        public AzureNetworkVnetGatewayCreateTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkVnetGatewayCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// VPN routing type.
        /// </summary>
        public AzureNetworkVnetGatewayCreateTask VpnType(string vpnType = null)
        {
            WithArguments("--vpn-type");
            if (!string.IsNullOrEmpty(vpnType))
            {
                 WithArguments(vpnType);
            }

            return this;
        }

        /// <summary>
        /// Autonomous System Number to use for the BGP settings.
        /// </summary>
        public AzureNetworkVnetGatewayCreateTask Asn(string asn = null)
        {
            WithArguments("--asn");
            if (!string.IsNullOrEmpty(asn))
            {
                 WithArguments(asn);
            }

            return this;
        }

        /// <summary>
        /// IP address to use for BGP peering.
        /// </summary>
        public AzureNetworkVnetGatewayCreateTask BgpPeeringAddress(string bgpPeeringAddress = null)
        {
            WithArguments("--bgp-peering-address");
            if (!string.IsNullOrEmpty(bgpPeeringAddress))
            {
                 WithArguments(bgpPeeringAddress);
            }

            return this;
        }

        /// <summary>
        /// Weight (0-100) added to routes learned through BGP peering.
        /// </summary>
        public AzureNetworkVnetGatewayCreateTask PeerWeight(string peerWeight = null)
        {
            WithArguments("--peer-weight");
            if (!string.IsNullOrEmpty(peerWeight))
            {
                 WithArguments(peerWeight);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of CIDR prefixes representing the address space for the P2S client.
        /// </summary>
        public AzureNetworkVnetGatewayCreateTask AddressPrefixes(string addressPrefixes = null)
        {
            WithArguments("--address-prefixes");
            if (!string.IsNullOrEmpty(addressPrefixes))
            {
                 WithArguments(addressPrefixes);
            }

            return this;
        }

        /// <summary>
        /// Protocols to use for connecting.
        /// </summary>
        public AzureNetworkVnetGatewayCreateTask ClientProtocol(string clientProtocol = null)
        {
            WithArguments("--client-protocol");
            if (!string.IsNullOrEmpty(clientProtocol))
            {
                 WithArguments(clientProtocol);
            }

            return this;
        }

        /// <summary>
        /// Radius secret to use for authentication.
        /// </summary>
        public AzureNetworkVnetGatewayCreateTask RadiusSecret(string radiusSecret = null)
        {
            WithArguments("--radius-secret");
            if (!string.IsNullOrEmpty(radiusSecret))
            {
                 WithArguments(radiusSecret);
            }

            return this;
        }

        /// <summary>
        /// Radius server address to connect to.
        /// </summary>
        public AzureNetworkVnetGatewayCreateTask RadiusServer(string radiusServer = null)
        {
            WithArguments("--radius-server");
            if (!string.IsNullOrEmpty(radiusServer))
            {
                 WithArguments(radiusServer);
            }

            return this;
        }
     }
}
