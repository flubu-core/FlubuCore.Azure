
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetGatewayUpdateTask : ExternalProcessTaskBase<AzureNetworkVnetGatewayUpdateTask>
     {
        
        /// <summary>
        /// Update a virtual network gateway.
        /// </summary>
        public AzureNetworkVnetGatewayUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vnet-gateway update");
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
        
        /// <summary>
        /// The gateway type.
        /// </summary>
        public AzureNetworkVnetGatewayUpdateTask GatewayType(string gatewayType = null)
        {
            WithArguments("--gateway-type");
            if (!string.IsNullOrEmpty(gatewayType))
            {
                 WithArguments(gatewayType);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkVnetGatewayUpdateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Specify a single public IP (name or ID) for an active-standby gateway. Specify two space-separated public IPs for an active-active gateway.
        /// </summary>
        public AzureNetworkVnetGatewayUpdateTask PublicIpAddresses(string publicIpAddresses = null)
        {
            WithArguments("--public-ip-addresses");
            if (!string.IsNullOrEmpty(publicIpAddresses))
            {
                 WithArguments(publicIpAddresses);
            }

            return this;
        }

        /// <summary>
        /// VNet gateway SKU.
        /// </summary>
        public AzureNetworkVnetGatewayUpdateTask Sku(string sku = null)
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
        public AzureNetworkVnetGatewayUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of a virtual network that contains a subnet named 'GatewaySubnet'.
        /// </summary>
        public AzureNetworkVnetGatewayUpdateTask Vnet(string vnet = null)
        {
            WithArguments("--vnet");
            if (!string.IsNullOrEmpty(vnet))
            {
                 WithArguments(vnet);
            }

            return this;
        }

        /// <summary>
        /// VPN routing type.
        /// </summary>
        public AzureNetworkVnetGatewayUpdateTask VpnType(string vpnType = null)
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
        public AzureNetworkVnetGatewayUpdateTask Asn(string asn = null)
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
        public AzureNetworkVnetGatewayUpdateTask BgpPeeringAddress(string bgpPeeringAddress = null)
        {
            WithArguments("--bgp-peering-address");
            if (!string.IsNullOrEmpty(bgpPeeringAddress))
            {
                 WithArguments(bgpPeeringAddress);
            }

            return this;
        }

        /// <summary>
        /// Enable BGP (Border Gateway Protocol).
        /// </summary>
        public AzureNetworkVnetGatewayUpdateTask EnableBgp(string enableBgp = null)
        {
            WithArguments("--enable-bgp");
            if (!string.IsNullOrEmpty(enableBgp))
            {
                 WithArguments(enableBgp);
            }

            return this;
        }

        /// <summary>
        /// Weight (0-100) added to routes learned through BGP peering.
        /// </summary>
        public AzureNetworkVnetGatewayUpdateTask PeerWeight(string peerWeight = null)
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
        public AzureNetworkVnetGatewayUpdateTask AddressPrefixes(string addressPrefixes = null)
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
        public AzureNetworkVnetGatewayUpdateTask ClientProtocol(string clientProtocol = null)
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
        public AzureNetworkVnetGatewayUpdateTask RadiusSecret(string radiusSecret = null)
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
        public AzureNetworkVnetGatewayUpdateTask RadiusServer(string radiusServer = null)
        {
            WithArguments("--radius-server");
            if (!string.IsNullOrEmpty(radiusServer))
            {
                 WithArguments(radiusServer);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkVnetGatewayUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureNetworkVnetGatewayUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureNetworkVnetGatewayUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureNetworkVnetGatewayUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
