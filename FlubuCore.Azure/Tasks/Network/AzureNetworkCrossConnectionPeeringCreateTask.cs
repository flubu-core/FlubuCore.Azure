
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkCrossConnectionPeeringCreateTask : ExternalProcessTaskBase<AzureNetworkCrossConnectionPeeringCreateTask>
     {
        
        /// <summary>
        /// Create peering settings for an ExpressRoute circuit.
        /// </summary>
        public AzureNetworkCrossConnectionPeeringCreateTask(string crossConnectionName = null ,  string peerAsn = null ,  string peeringType = null ,  string primaryPeerSubnet = null ,  string resourceGroup = null ,  string secondaryPeerSubnet = null ,  string vlanId = null)
        {
            WithArguments("az network cross-connection peering create");
WithArguments("--cross-connection-name");
            if (!string.IsNullOrEmpty(crossConnectionName))
            {
                 WithArguments(crossConnectionName);
            }

WithArguments("--peer-asn");
            if (!string.IsNullOrEmpty(peerAsn))
            {
                 WithArguments(peerAsn);
            }

WithArguments("--peering-type");
            if (!string.IsNullOrEmpty(peeringType))
            {
                 WithArguments(peeringType);
            }

WithArguments("--primary-peer-subnet");
            if (!string.IsNullOrEmpty(primaryPeerSubnet))
            {
                 WithArguments(primaryPeerSubnet);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--secondary-peer-subnet");
            if (!string.IsNullOrEmpty(secondaryPeerSubnet))
            {
                 WithArguments(secondaryPeerSubnet);
            }

WithArguments("--vlan-id");
            if (!string.IsNullOrEmpty(vlanId))
            {
                 WithArguments(vlanId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Key for generating an MD5 for the BGP session.
        /// </summary>
        public AzureNetworkCrossConnectionPeeringCreateTask SharedKey(string sharedKey = null)
        {
            WithArguments("--shared-key");
            if (!string.IsNullOrEmpty(sharedKey))
            {
                 WithArguments(sharedKey);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of prefixes to be advertised through the BGP peering.
        /// </summary>
        public AzureNetworkCrossConnectionPeeringCreateTask AdvertisedPublicPrefixes(string advertisedPublicPrefixes = null)
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
        public AzureNetworkCrossConnectionPeeringCreateTask CustomerAsn(string customerAsn = null)
        {
            WithArguments("--customer-asn");
            if (!string.IsNullOrEmpty(customerAsn))
            {
                 WithArguments(customerAsn);
            }

            return this;
        }

        /// <summary>
        /// Internet Routing Registry / Regional Internet Registry.
        /// </summary>
        public AzureNetworkCrossConnectionPeeringCreateTask RoutingRegistryName(string routingRegistryName = null)
        {
            WithArguments("--routing-registry-name");
            if (!string.IsNullOrEmpty(routingRegistryName))
            {
                 WithArguments(routingRegistryName);
            }

            return this;
        }
     }
}
