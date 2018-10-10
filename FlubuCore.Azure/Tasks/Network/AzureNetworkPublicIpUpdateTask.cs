
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkPublicIpUpdateTask : ExternalProcessTaskBase<AzureNetworkPublicIpUpdateTask>
     {
        
        /// <summary>
        /// Update a public IP address.
        /// </summary>
        public AzureNetworkPublicIpUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network public-ip update");
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
        public AzureNetworkPublicIpUpdateTask AllocationMethod(string allocationMethod = null)
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
        public AzureNetworkPublicIpUpdateTask DnsName(string dnsName = null)
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
        public AzureNetworkPublicIpUpdateTask IdleTimeout(string idleTimeout = null)
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
        public AzureNetworkPublicIpUpdateTask IpTags(string ipTags = null)
        {
            WithArguments("--ip-tags");
            if (!string.IsNullOrEmpty(ipTags))
            {
                 WithArguments(ipTags);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of a public IP prefix.
        /// </summary>
        public AzureNetworkPublicIpUpdateTask PublicIpPrefix(string publicIpPrefix = null)
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
        public AzureNetworkPublicIpUpdateTask ReverseFqdn(string reverseFqdn = null)
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
        public AzureNetworkPublicIpUpdateTask Sku(string sku = null)
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
        public AzureNetworkPublicIpUpdateTask Tags(string tags = null)
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
        public AzureNetworkPublicIpUpdateTask Version(string version = null)
        {
            WithArguments("--version");
            if (!string.IsNullOrEmpty(version))
            {
                 WithArguments(version);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkPublicIpUpdateTask Add(string add = null)
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
        public AzureNetworkPublicIpUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkPublicIpUpdateTask Remove(string remove = null)
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
        public AzureNetworkPublicIpUpdateTask Set(string set = null)
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
