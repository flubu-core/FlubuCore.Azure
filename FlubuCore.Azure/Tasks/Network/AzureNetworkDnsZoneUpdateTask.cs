
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsZoneUpdateTask : ExternalProcessTaskBase<AzureNetworkDnsZoneUpdateTask>
     {
        
        /// <summary>
        /// Update a DNS zone's properties. Does not modify DNS records within the zone.
        /// </summary>
        public AzureNetworkDnsZoneUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network dns zone update");
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
        /// Update only if the resource with the same ETAG exists.
        /// </summary>
        public AzureNetworkDnsZoneUpdateTask IfMatch(string ifMatch = null)
        {
            WithArguments("--if-match");
            if (!string.IsNullOrEmpty(ifMatch))
            {
                 WithArguments(ifMatch);
            }

            return this;
        }

        /// <summary>
        /// Set to '*' to allow a new DNS zone to be created, but to prevent updating an existing zone. Other values will be ignored.
        /// </summary>
        public AzureNetworkDnsZoneUpdateTask IfNoneMatch(string ifNoneMatch = null)
        {
            WithArguments("--if-none-match");
            if (!string.IsNullOrEmpty(ifNoneMatch))
            {
                 WithArguments(ifNoneMatch);
            }

            return this;
        }

        /// <summary>
        /// Resource tags for the DNS zone.
        /// </summary>
        public AzureNetworkDnsZoneUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Type of DNS zone to create.
        /// </summary>
        public AzureNetworkDnsZoneUpdateTask ZoneType(string zoneType = null)
        {
            WithArguments("--zone-type");
            if (!string.IsNullOrEmpty(zoneType))
            {
                 WithArguments(zoneType);
            }

            return this;
        }

        /// <summary>
        /// Space-separated names or IDs of virtual networks that register hostnames in this DNS zone. Only applies to 'Private' zones.
        /// </summary>
        public AzureNetworkDnsZoneUpdateTask RegistrationVnets(string registrationVnets = null)
        {
            WithArguments("--registration-vnets");
            if (!string.IsNullOrEmpty(registrationVnets))
            {
                 WithArguments(registrationVnets);
            }

            return this;
        }

        /// <summary>
        /// Space-separated names or IDs of virtual networks that resolve records in this DNS zone. Only applies to 'Private' zones.
        /// </summary>
        public AzureNetworkDnsZoneUpdateTask ResolutionVnets(string resolutionVnets = null)
        {
            WithArguments("--resolution-vnets");
            if (!string.IsNullOrEmpty(resolutionVnets))
            {
                 WithArguments(resolutionVnets);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkDnsZoneUpdateTask Add(string add = null)
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
        public AzureNetworkDnsZoneUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkDnsZoneUpdateTask Remove(string remove = null)
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
        public AzureNetworkDnsZoneUpdateTask Set(string set = null)
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
