
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkPublicIpCreateTask : ExternalProcessTaskBase<AzureNetworkPublicIpCreateTask>
     {
        
        /// <summary>
        /// Create a public IP address.
        /// </summary>
        public AzureNetworkPublicIpCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network public-ip create");
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
        /// IP address allocation method.
        /// </summary>
        public AzureNetworkPublicIpCreateTask AllocationMethod(string allocationMethod = null)
        {
            WithArguments("--allocation-method");
            if (!string.IsNullOrEmpty(allocationMethod))
            {
                 WithArguments(allocationMethod);
            }

            return this;
        }

        /// <summary>
        /// Globally unique DNS entry.
        /// </summary>
        public AzureNetworkPublicIpCreateTask DnsName(string dnsName = null)
        {
            WithArguments("--dns-name");
            if (!string.IsNullOrEmpty(dnsName))
            {
                 WithArguments(dnsName);
            }

            return this;
        }

        /// <summary>
        /// Idle timeout in minutes.
        /// </summary>
        public AzureNetworkPublicIpCreateTask IdleTimeout(string idleTimeout = null)
        {
            WithArguments("--idle-timeout");
            if (!string.IsNullOrEmpty(idleTimeout))
            {
                 WithArguments(idleTimeout);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of IP tags in 'TYPE=VAL' format.
        /// </summary>
        public AzureNetworkPublicIpCreateTask IpTags(string ipTags = null)
        {
            WithArguments("--ip-tags");
            if (!string.IsNullOrEmpty(ipTags))
            {
                 WithArguments(ipTags);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkPublicIpCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of a public IP prefix.
        /// </summary>
        public AzureNetworkPublicIpCreateTask PublicIpPrefix(string publicIpPrefix = null)
        {
            WithArguments("--public-ip-prefix");
            if (!string.IsNullOrEmpty(publicIpPrefix))
            {
                 WithArguments(publicIpPrefix);
            }

            return this;
        }

        /// <summary>
        /// Reverse FQDN (fully qualified domain name).
        /// </summary>
        public AzureNetworkPublicIpCreateTask ReverseFqdn(string reverseFqdn = null)
        {
            WithArguments("--reverse-fqdn");
            if (!string.IsNullOrEmpty(reverseFqdn))
            {
                 WithArguments(reverseFqdn);
            }

            return this;
        }

        /// <summary>
        /// Public IP SKU.
        /// </summary>
        public AzureNetworkPublicIpCreateTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkPublicIpCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// IP address type.
        /// </summary>
        public AzureNetworkPublicIpCreateTask Version(string version = null)
        {
            WithArguments("--version");
            if (!string.IsNullOrEmpty(version))
            {
                 WithArguments(version);
            }

            return this;
        }

        /// <summary>
        /// Availability zone into which to provision the resource.
        /// </summary>
        public AzureNetworkPublicIpCreateTask Zone(string zone = null)
        {
            WithArguments("--zone");
            if (!string.IsNullOrEmpty(zone))
            {
                 WithArguments(zone);
            }

            return this;
        }
     }
}
