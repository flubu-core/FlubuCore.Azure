
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnGatewayCreateTask : ExternalProcessTaskBase<AzureNetworkVpnGatewayCreateTask>
     {
        
        /// <summary>
        /// Create a VPN gateway.
        /// </summary>
        public AzureNetworkVpnGatewayCreateTask(string name = null ,  string resourceGroup = null ,  string vhub = null)
        {
            WithArguments("az network vpn-gateway create");
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

WithArguments("--vhub");
            if (!string.IsNullOrEmpty(vhub))
            {
                 WithArguments(vhub);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkVpnGatewayCreateTask Location(string location = null)
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
        public AzureNetworkVpnGatewayCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// The scale unit for this VPN gateway.
        /// </summary>
        public AzureNetworkVpnGatewayCreateTask ScaleUnit(string scaleUnit = null)
        {
            WithArguments("--scale-unit");
            if (!string.IsNullOrEmpty(scaleUnit))
            {
                 WithArguments(scaleUnit);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkVpnGatewayCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// BGP speaker's ASN.
        /// </summary>
        public AzureNetworkVpnGatewayCreateTask Asn(string asn = null)
        {
            WithArguments("--asn");
            if (!string.IsNullOrEmpty(asn))
            {
                 WithArguments(asn);
            }

            return this;
        }

        /// <summary>
        /// Peering address and BGP identifier of this BGP speaker.
        /// </summary>
        public AzureNetworkVpnGatewayCreateTask BgpPeeringAddress(string bgpPeeringAddress = null)
        {
            WithArguments("--bgp-peering-address");
            if (!string.IsNullOrEmpty(bgpPeeringAddress))
            {
                 WithArguments(bgpPeeringAddress);
            }

            return this;
        }

        /// <summary>
        /// Weight added to routes learned from this BGP speaker.
        /// </summary>
        public AzureNetworkVpnGatewayCreateTask PeerWeight(string peerWeight = null)
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
