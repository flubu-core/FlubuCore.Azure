
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkTrafficManagerEndpointCreateTask : ExternalProcessTaskBase<AzureNetworkTrafficManagerEndpointCreateTask>
     {
        
        /// <summary>
        /// Create a traffic manager endpoint.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointCreateTask(string name = null ,  string profileName = null ,  string resourceGroup = null ,  string type = null)
        {
            WithArguments("az network traffic-manager endpoint create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--profile-name");
            if (!string.IsNullOrEmpty(profileName))
            {
                 WithArguments(profileName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--type");
            if (!string.IsNullOrEmpty(type))
            {
                 WithArguments(type);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Location of the external or nested endpoints when using the 'Performance' routing method.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointCreateTask EndpointLocation(string endpointLocation = null)
        {
            WithArguments("--endpoint-location");
            if (!string.IsNullOrEmpty(endpointLocation))
            {
                 WithArguments(endpointLocation);
            }

            return this;
        }

        /// <summary>
        /// The monitoring status of the endpoint.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointCreateTask EndpointMonitorStatus(string endpointMonitorStatus = null)
        {
            WithArguments("--endpoint-monitor-status");
            if (!string.IsNullOrEmpty(endpointMonitorStatus))
            {
                 WithArguments(endpointMonitorStatus);
            }

            return this;
        }

        /// <summary>
        /// The status of the endpoint. If enabled the endpoint is probed for endpoint health and included in the traffic routing method.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointCreateTask EndpointStatus(string endpointStatus = null)
        {
            WithArguments("--endpoint-status");
            if (!string.IsNullOrEmpty(endpointStatus))
            {
                 WithArguments(endpointStatus);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of country/region codes mapped to this endpoint when using the 'Geographic' routing method.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointCreateTask GeoMapping(string geoMapping = null)
        {
            WithArguments("--geo-mapping");
            if (!string.IsNullOrEmpty(geoMapping))
            {
                 WithArguments(geoMapping);
            }

            return this;
        }

        /// <summary>
        /// The minimum number of endpoints that must be available in the child profile for the parent profile to be considered available. Only applicable to an endpoint of type 'NestedEndpoints'.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointCreateTask MinChildEndpoints(string minChildEndpoints = null)
        {
            WithArguments("--min-child-endpoints");
            if (!string.IsNullOrEmpty(minChildEndpoints))
            {
                 WithArguments(minChildEndpoints);
            }

            return this;
        }

        /// <summary>
        /// Priority of the endpoint when using the 'Priority' traffic routing method. Values range from 1 to 1000, with lower values representing higher priority.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointCreateTask Priority(string priority = null)
        {
            WithArguments("--priority");
            if (!string.IsNullOrEmpty(priority))
            {
                 WithArguments(priority);
            }

            return this;
        }

        /// <summary>
        /// Fully-qualified DNS name of the endpoint.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointCreateTask Target(string target = null)
        {
            WithArguments("--target");
            if (!string.IsNullOrEmpty(target))
            {
                 WithArguments(target);
            }

            return this;
        }

        /// <summary>
        /// The Azure Resource URI of the endpoint. Not applicable for endpoints of type 'ExternalEndpoints'.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointCreateTask TargetResourceId(string targetResourceId = null)
        {
            WithArguments("--target-resource-id");
            if (!string.IsNullOrEmpty(targetResourceId))
            {
                 WithArguments(targetResourceId);
            }

            return this;
        }

        /// <summary>
        /// Weight of the endpoint when using the 'Weighted' traffic routing method. Values range from 1 to 1000.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointCreateTask Weight(string weight = null)
        {
            WithArguments("--weight");
            if (!string.IsNullOrEmpty(weight))
            {
                 WithArguments(weight);
            }

            return this;
        }
     }
}
