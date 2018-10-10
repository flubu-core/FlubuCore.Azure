
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkTrafficManagerEndpointUpdateTask : ExternalProcessTaskBase<AzureNetworkTrafficManagerEndpointUpdateTask>
     {
        
        /// <summary>
        /// Update a traffic manager endpoint.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointUpdateTask(string name = null ,  string profileName = null ,  string resourceGroup = null)
        {
            WithArguments("az network traffic-manager endpoint update");
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

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Location of the external or nested endpoints when using the 'Performance' routing method.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointUpdateTask EndpointLocation(string endpointLocation = null)
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
        public AzureNetworkTrafficManagerEndpointUpdateTask EndpointMonitorStatus(string endpointMonitorStatus = null)
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
        public AzureNetworkTrafficManagerEndpointUpdateTask EndpointStatus(string endpointStatus = null)
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
        public AzureNetworkTrafficManagerEndpointUpdateTask GeoMapping(string geoMapping = null)
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
        public AzureNetworkTrafficManagerEndpointUpdateTask MinChildEndpoints(string minChildEndpoints = null)
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
        public AzureNetworkTrafficManagerEndpointUpdateTask Priority(string priority = null)
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
        public AzureNetworkTrafficManagerEndpointUpdateTask Target(string target = null)
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
        public AzureNetworkTrafficManagerEndpointUpdateTask TargetResourceId(string targetResourceId = null)
        {
            WithArguments("--target-resource-id");
            if (!string.IsNullOrEmpty(targetResourceId))
            {
                 WithArguments(targetResourceId);
            }

            return this;
        }

        /// <summary>
        /// Endpoint type.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointUpdateTask Type(string type = null)
        {
            WithArguments("--type");
            if (!string.IsNullOrEmpty(type))
            {
                 WithArguments(type);
            }

            return this;
        }

        /// <summary>
        /// Weight of the endpoint when using the 'Weighted' traffic routing method. Values range from 1 to 1000.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointUpdateTask Weight(string weight = null)
        {
            WithArguments("--weight");
            if (!string.IsNullOrEmpty(weight))
            {
                 WithArguments(weight);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkTrafficManagerEndpointUpdateTask Add(string add = null)
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
        public AzureNetworkTrafficManagerEndpointUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkTrafficManagerEndpointUpdateTask Remove(string remove = null)
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
        public AzureNetworkTrafficManagerEndpointUpdateTask Set(string set = null)
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
