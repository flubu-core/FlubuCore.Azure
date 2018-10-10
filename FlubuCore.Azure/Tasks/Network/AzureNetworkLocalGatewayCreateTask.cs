
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLocalGatewayCreateTask : ExternalProcessTaskBase<AzureNetworkLocalGatewayCreateTask>
     {
        
        /// <summary>
        /// Create a local VPN gateway.
        /// </summary>
        public AzureNetworkLocalGatewayCreateTask(string gatewayIpAddress = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network local-gateway create");
WithArguments("--gateway-ip-address");
            if (!string.IsNullOrEmpty(gatewayIpAddress))
            {
                 WithArguments(gatewayIpAddress);
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
        
        /// <summary>
        /// List of CIDR block prefixes representing the address space of the OnPremise VPN's subnet.
        /// </summary>
        public AzureNetworkLocalGatewayCreateTask LocalAddressPrefixes(string localAddressPrefixes = null)
        {
            WithArguments("--local-address-prefixes");
            if (!string.IsNullOrEmpty(localAddressPrefixes))
            {
                 WithArguments(localAddressPrefixes);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkLocalGatewayCreateTask Location(string location = null)
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
        public AzureNetworkLocalGatewayCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkLocalGatewayCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Autonomous System Number to use for the BGP settings.
        /// </summary>
        public AzureNetworkLocalGatewayCreateTask Asn(string asn = null)
        {
            WithArguments("--asn");
            if (!string.IsNullOrEmpty(asn))
            {
                 WithArguments(asn);
            }

            return this;
        }

        /// <summary>
        /// IP address from the OnPremise VPN's subnet to use for BGP peering.
        /// </summary>
        public AzureNetworkLocalGatewayCreateTask BgpPeeringAddress(string bgpPeeringAddress = null)
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
        public AzureNetworkLocalGatewayCreateTask PeerWeight(string peerWeight = null)
        {
            WithArguments("--peer-weight");
            if (!string.IsNullOrEmpty(peerWeight))
            {
                 WithArguments(peerWeight);
            }

            return this;
        }
     }
}
