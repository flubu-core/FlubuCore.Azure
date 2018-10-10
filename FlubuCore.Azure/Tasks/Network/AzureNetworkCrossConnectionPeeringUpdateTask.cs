
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkCrossConnectionPeeringUpdateTask : ExternalProcessTaskBase<AzureNetworkCrossConnectionPeeringUpdateTask>
     {
        
        /// <summary>
        /// Update peering settings of an ExpressRoute circuit.
        /// </summary>
        public AzureNetworkCrossConnectionPeeringUpdateTask(string crossConnectionName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network cross-connection peering update");
WithArguments("--cross-connection-name");
            if (!string.IsNullOrEmpty(crossConnectionName))
            {
                 WithArguments(crossConnectionName);
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
        public AzureNetworkCrossConnectionPeeringUpdateTask PeerAsn(string peerAsn = null)
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
        public AzureNetworkCrossConnectionPeeringUpdateTask PrimaryPeerSubnet(string primaryPeerSubnet = null)
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
        public AzureNetworkCrossConnectionPeeringUpdateTask SecondaryPeerSubnet(string secondaryPeerSubnet = null)
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
        public AzureNetworkCrossConnectionPeeringUpdateTask SharedKey(string sharedKey = null)
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
        public AzureNetworkCrossConnectionPeeringUpdateTask VlanId(string vlanId = null)
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
        public AzureNetworkCrossConnectionPeeringUpdateTask AdvertisedPublicPrefixes(string advertisedPublicPrefixes = null)
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
        public AzureNetworkCrossConnectionPeeringUpdateTask CustomerAsn(string customerAsn = null)
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
        public AzureNetworkCrossConnectionPeeringUpdateTask IpVersion(string ipVersion = null)
        {
            WithArguments("--ip-version");
            if (!string.IsNullOrEmpty(ipVersion))
            {
                 WithArguments(ipVersion);
            }

            return this;
        }

        /// <summary>
        /// Internet Routing Registry / Regional Internet Registry.
        /// </summary>
        public AzureNetworkCrossConnectionPeeringUpdateTask RoutingRegistryName(string routingRegistryName = null)
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
        public AzureNetworkCrossConnectionPeeringUpdateTask Add(string add = null)
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
        public AzureNetworkCrossConnectionPeeringUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkCrossConnectionPeeringUpdateTask Remove(string remove = null)
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
        public AzureNetworkCrossConnectionPeeringUpdateTask Set(string set = null)
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
