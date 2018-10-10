
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsZoneCreateTask : ExternalProcessTaskBase<AzureNetworkDnsZoneCreateTask>
     {
        
        /// <summary>
        /// Create a DNS zone.
        /// </summary>
        public AzureNetworkDnsZoneCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network dns zone create");
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
        /// Only create a DNS zone if one doesn't exist that matches the given name.
        /// </summary>
        public AzureNetworkDnsZoneCreateTask IfNoneMatch(string ifNoneMatch = null)
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
        public AzureNetworkDnsZoneCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Type of the zone to be created. Valid values are 'Public' and 'Private'.
        /// </summary>
        public AzureNetworkDnsZoneCreateTask ZoneType(string zoneType = null)
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
        public AzureNetworkDnsZoneCreateTask RegistrationVnets(string registrationVnets = null)
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
        public AzureNetworkDnsZoneCreateTask ResolutionVnets(string resolutionVnets = null)
        {
            WithArguments("--resolution-vnets");
            if (!string.IsNullOrEmpty(resolutionVnets))
            {
                 WithArguments(resolutionVnets);
            }

            return this;
        }
     }
}
