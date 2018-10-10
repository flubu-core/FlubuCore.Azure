
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLocalGatewayUpdateTask : ExternalProcessTaskBase<AzureNetworkLocalGatewayUpdateTask>
     {
        
        /// <summary>
        /// Update a local VPN gateway.
        /// </summary>
        public AzureNetworkLocalGatewayUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network local-gateway update");
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
        /// Gateway's public IP address. (e.g. 10.1.1.1).
        /// </summary>
        public AzureNetworkLocalGatewayUpdateTask GatewayIpAddress(string gatewayIpAddress = null)
        {
            WithArguments("--gateway-ip-address");
            if (!string.IsNullOrEmpty(gatewayIpAddress))
            {
                 WithArguments(gatewayIpAddress);
            }

            return this;
        }

        /// <summary>
        /// List of CIDR block prefixes representing the address space of the OnPremise VPN's subnet.
        /// </summary>
        public AzureNetworkLocalGatewayUpdateTask LocalAddressPrefixes(string localAddressPrefixes = null)
        {
            WithArguments("--local-address-prefixes");
            if (!string.IsNullOrEmpty(localAddressPrefixes))
            {
                 WithArguments(localAddressPrefixes);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkLocalGatewayUpdateTask NoWait(string noWait = null)
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
        public AzureNetworkLocalGatewayUpdateTask Tags(string tags = null)
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
        public AzureNetworkLocalGatewayUpdateTask Asn(string asn = null)
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
        public AzureNetworkLocalGatewayUpdateTask BgpPeeringAddress(string bgpPeeringAddress = null)
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
        public AzureNetworkLocalGatewayUpdateTask PeerWeight(string peerWeight = null)
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
        public AzureNetworkLocalGatewayUpdateTask Add(string add = null)
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
        public AzureNetworkLocalGatewayUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkLocalGatewayUpdateTask Remove(string remove = null)
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
        public AzureNetworkLocalGatewayUpdateTask Set(string set = null)
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
