
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnGatewayUpdateTask : ExternalProcessTaskBase<AzureNetworkVpnGatewayUpdateTask>
     {
        
        /// <summary>
        /// Update settings of a VPN gateway.
        /// </summary>
        public AzureNetworkVpnGatewayUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vpn-gateway update");
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
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkVpnGatewayUpdateTask NoWait(string noWait = null)
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
        public AzureNetworkVpnGatewayUpdateTask ScaleUnit(string scaleUnit = null)
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
        public AzureNetworkVpnGatewayUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of a virtual hub.
        /// </summary>
        public AzureNetworkVpnGatewayUpdateTask Vhub(string vhub = null)
        {
            WithArguments("--vhub");
            if (!string.IsNullOrEmpty(vhub))
            {
                 WithArguments(vhub);
            }

            return this;
        }

        /// <summary>
        /// BGP speaker's ASN.
        /// </summary>
        public AzureNetworkVpnGatewayUpdateTask Asn(string asn = null)
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
        public AzureNetworkVpnGatewayUpdateTask BgpPeeringAddress(string bgpPeeringAddress = null)
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
        public AzureNetworkVpnGatewayUpdateTask PeerWeight(string peerWeight = null)
        {
            WithArguments("--peer-weight");
            if (!string.IsNullOrEmpty(peerWeight))
            {
                 WithArguments(peerWeight);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkVpnGatewayUpdateTask Add(string add = null)
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
        public AzureNetworkVpnGatewayUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkVpnGatewayUpdateTask Remove(string remove = null)
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
        public AzureNetworkVpnGatewayUpdateTask Set(string set = null)
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
