
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRoutePeeringUpdateTask : ExternalProcessTaskBase<AzureNetworkExpressRoutePeeringUpdateTask>
     {
        
        /// <summary>
        /// Update peering settings of an ExpressRoute circuit.
        /// </summary>
        public AzureNetworkExpressRoutePeeringUpdateTask(string circuitName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network express-route peering update");
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
        
        /// <summary>
        /// Autonomous system number of the customer/connectivity provider.
        /// </summary>
        public AzureNetworkExpressRoutePeeringUpdateTask PeerAsn(string peerAsn = null)
        {
            WithArguments("--peer-asn");
            if (!string.IsNullOrEmpty(peerAsn))
            {
                 WithArguments(peerAsn);
            }

            return this;
        }

        /// <summary>
        /// /30 subnet used to configure IP addresses for primary interface.
        /// </summary>
        public AzureNetworkExpressRoutePeeringUpdateTask PrimaryPeerSubnet(string primaryPeerSubnet = null)
        {
            WithArguments("--primary-peer-subnet");
            if (!string.IsNullOrEmpty(primaryPeerSubnet))
            {
                 WithArguments(primaryPeerSubnet);
            }

            return this;
        }

        /// <summary>
        /// /30 subnet used to configure IP addresses for secondary interface.
        /// </summary>
        public AzureNetworkExpressRoutePeeringUpdateTask SecondaryPeerSubnet(string secondaryPeerSubnet = null)
        {
            WithArguments("--secondary-peer-subnet");
            if (!string.IsNullOrEmpty(secondaryPeerSubnet))
            {
                 WithArguments(secondaryPeerSubnet);
            }

            return this;
        }

        /// <summary>
        /// Key for generating an MD5 for the BGP session.
        /// </summary>
        public AzureNetworkExpressRoutePeeringUpdateTask SharedKey(string sharedKey = null)
        {
            WithArguments("--shared-key");
            if (!string.IsNullOrEmpty(sharedKey))
            {
                 WithArguments(sharedKey);
            }

            return this;
        }

        /// <summary>
        /// Identifier used to identify the customer.
        /// </summary>
        public AzureNetworkExpressRoutePeeringUpdateTask VlanId(string vlanId = null)
        {
            WithArguments("--vlan-id");
            if (!string.IsNullOrEmpty(vlanId))
            {
                 WithArguments(vlanId);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of prefixes to be advertised through the BGP peering.
        /// </summary>
        public AzureNetworkExpressRoutePeeringUpdateTask AdvertisedPublicPrefixes(string advertisedPublicPrefixes = null)
        {
            WithArguments("--advertised-public-prefixes");
            if (!string.IsNullOrEmpty(advertisedPublicPrefixes))
            {
                 WithArguments(advertisedPublicPrefixes);
            }

            return this;
        }

        /// <summary>
        /// Autonomous system number of the customer.
        /// </summary>
        public AzureNetworkExpressRoutePeeringUpdateTask CustomerAsn(string customerAsn = null)
        {
            WithArguments("--customer-asn");
            if (!string.IsNullOrEmpty(customerAsn))
            {
                 WithArguments(customerAsn);
            }

            return this;
        }

        /// <summary>
        /// The IP version to update Microsoft Peering settings for.
        /// </summary>
        public AzureNetworkExpressRoutePeeringUpdateTask IpVersion(string ipVersion = null)
        {
            WithArguments("--ip-version");
            if (!string.IsNullOrEmpty(ipVersion))
            {
                 WithArguments(ipVersion);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of a route filter to apply to the peering settings.
        /// </summary>
        public AzureNetworkExpressRoutePeeringUpdateTask RouteFilter(string routeFilter = null)
        {
            WithArguments("--route-filter");
            if (!string.IsNullOrEmpty(routeFilter))
            {
                 WithArguments(routeFilter);
            }

            return this;
        }

        /// <summary>
        /// Internet Routing Registry / Regional Internet Registry.
        /// </summary>
        public AzureNetworkExpressRoutePeeringUpdateTask RoutingRegistryName(string routingRegistryName = null)
        {
            WithArguments("--routing-registry-name");
            if (!string.IsNullOrEmpty(routingRegistryName))
            {
                 WithArguments(routingRegistryName);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkExpressRoutePeeringUpdateTask Add(string add = null)
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
        public AzureNetworkExpressRoutePeeringUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkExpressRoutePeeringUpdateTask Remove(string remove = null)
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
        public AzureNetworkExpressRoutePeeringUpdateTask Set(string set = null)
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
