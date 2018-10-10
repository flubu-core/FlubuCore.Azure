
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRoutePeeringCreateTask : ExternalProcessTaskBase<AzureNetworkExpressRoutePeeringCreateTask>
     {
        
        /// <summary>
        /// Create peering settings for an ExpressRoute circuit.
        /// </summary>
        public AzureNetworkExpressRoutePeeringCreateTask(string circuitName = null ,  string peerAsn = null ,  string peeringType = null ,  string primaryPeerSubnet = null ,  string resourceGroup = null ,  string secondaryPeerSubnet = null ,  string vlanId = null)
        {
            WithArguments("az network express-route peering create");
WithArguments("--circuit-name");
            if (!string.IsNullOrEmpty(circuitName))
            {
                 WithArguments(circuitName);
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
        public AzureNetworkExpressRoutePeeringCreateTask SharedKey(string sharedKey = null)
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
        public AzureNetworkExpressRoutePeeringCreateTask AdvertisedPublicPrefixes(string advertisedPublicPrefixes = null)
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
        public AzureNetworkExpressRoutePeeringCreateTask CustomerAsn(string customerAsn = null)
        {
            WithArguments("--customer-asn");
            if (!string.IsNullOrEmpty(customerAsn))
            {
                 WithArguments(customerAsn);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of a route filter to apply to the peering settings.
        /// </summary>
        public AzureNetworkExpressRoutePeeringCreateTask RouteFilter(string routeFilter = null)
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
        public AzureNetworkExpressRoutePeeringCreateTask RoutingRegistryName(string routingRegistryName = null)
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
