
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNicUpdateTask : ExternalProcessTaskBase<AzureNetworkNicUpdateTask>
     {
        
        /// <summary>
        /// Update a network interface.
        /// </summary>
        public AzureNetworkNicUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network nic update");
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
        /// Enable accelerated networking.
        /// </summary>
        public AzureNetworkNicUpdateTask AcceleratedNetworking(string acceleratedNetworking = null)
        {
            WithArguments("--accelerated-networking");
            if (!string.IsNullOrEmpty(acceleratedNetworking))
            {
                 WithArguments(acceleratedNetworking);
            }

            return this;
        }

        /// <summary>
        /// Enable IP forwarding.
        /// </summary>
        public AzureNetworkNicUpdateTask IpForwarding(string ipForwarding = null)
        {
            WithArguments("--ip-forwarding");
            if (!string.IsNullOrEmpty(ipForwarding))
            {
                 WithArguments(ipForwarding);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the associated network security group.
        /// </summary>
        public AzureNetworkNicUpdateTask NetworkSecurityGroup(string networkSecurityGroup = null)
        {
            WithArguments("--network-security-group");
            if (!string.IsNullOrEmpty(networkSecurityGroup))
            {
                 WithArguments(networkSecurityGroup);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkNicUpdateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of DNS server IP addresses. Use "" to revert to default Azure servers.
        /// </summary>
        public AzureNetworkNicUpdateTask DnsServers(string dnsServers = null)
        {
            WithArguments("--dns-servers");
            if (!string.IsNullOrEmpty(dnsServers))
            {
                 WithArguments(dnsServers);
            }

            return this;
        }

        /// <summary>
        /// The internal DNS name label.
        /// </summary>
        public AzureNetworkNicUpdateTask InternalDnsName(string internalDnsName = null)
        {
            WithArguments("--internal-dns-name");
            if (!string.IsNullOrEmpty(internalDnsName))
            {
                 WithArguments(internalDnsName);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkNicUpdateTask Add(string add = null)
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
        public AzureNetworkNicUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkNicUpdateTask Remove(string remove = null)
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
        public AzureNetworkNicUpdateTask Set(string set = null)
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
