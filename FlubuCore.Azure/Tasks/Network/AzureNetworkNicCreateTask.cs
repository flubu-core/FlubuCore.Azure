
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNicCreateTask : ExternalProcessTaskBase<AzureNetworkNicCreateTask>
     {
        
        /// <summary>
        /// Create a network interface.
        /// </summary>
        public AzureNetworkNicCreateTask(string name = null ,  string resourceGroup = null ,  string subnet = null)
        {
            WithArguments("az network nic create");
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

WithArguments("--subnet");
            if (!string.IsNullOrEmpty(subnet))
            {
                 WithArguments(subnet);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Enable accelerated networking.
        /// </summary>
        public AzureNetworkNicCreateTask AcceleratedNetworking(string acceleratedNetworking = null)
        {
            WithArguments("--accelerated-networking");
            if (!string.IsNullOrEmpty(acceleratedNetworking))
            {
                 WithArguments(acceleratedNetworking);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of application security groups.
        /// </summary>
        public AzureNetworkNicCreateTask ApplicationSecurityGroups(string applicationSecurityGroups = null)
        {
            WithArguments("--application-security-groups");
            if (!string.IsNullOrEmpty(applicationSecurityGroups))
            {
                 WithArguments(applicationSecurityGroups);
            }

            return this;
        }

        /// <summary>
        /// Enable IP forwarding.
        /// </summary>
        public AzureNetworkNicCreateTask IpForwarding(string ipForwarding = null)
        {
            WithArguments("--ip-forwarding");
            if (!string.IsNullOrEmpty(ipForwarding))
            {
                 WithArguments(ipForwarding);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of names or IDs of load balancer address pools to associate with the NIC. If names are used, --lb-name must be specified.
        /// </summary>
        public AzureNetworkNicCreateTask LbAddressPools(string lbAddressPools = null)
        {
            WithArguments("--lb-address-pools");
            if (!string.IsNullOrEmpty(lbAddressPools))
            {
                 WithArguments(lbAddressPools);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of names or IDs of load balancer inbound NAT rules to associate with the NIC. If names are used, --lb-name must be specified.
        /// </summary>
        public AzureNetworkNicCreateTask LbInboundNatRules(string lbInboundNatRules = null)
        {
            WithArguments("--lb-inbound-nat-rules");
            if (!string.IsNullOrEmpty(lbInboundNatRules))
            {
                 WithArguments(lbInboundNatRules);
            }

            return this;
        }

        /// <summary>
        /// The name of the load balancer to use when adding NAT rules or address pools by name (ignored when IDs are specified).
        /// </summary>
        public AzureNetworkNicCreateTask LbName(string lbName = null)
        {
            WithArguments("--lb-name");
            if (!string.IsNullOrEmpty(lbName))
            {
                 WithArguments(lbName);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkNicCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of an existing network security group, or none by default.
        /// </summary>
        public AzureNetworkNicCreateTask NetworkSecurityGroup(string networkSecurityGroup = null)
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
        public AzureNetworkNicCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Static private IP address to use.
        /// </summary>
        public AzureNetworkNicCreateTask PrivateIpAddress(string privateIpAddress = null)
        {
            WithArguments("--private-ip-address");
            if (!string.IsNullOrEmpty(privateIpAddress))
            {
                 WithArguments(privateIpAddress);
            }

            return this;
        }

        /// <summary>
        /// The private IP address version to use.
        /// </summary>
        public AzureNetworkNicCreateTask PrivateIpAddressVersion(string privateIpAddressVersion = null)
        {
            WithArguments("--private-ip-address-version");
            if (!string.IsNullOrEmpty(privateIpAddressVersion))
            {
                 WithArguments(privateIpAddressVersion);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of an existing public IP address, or none by default.
        /// </summary>
        public AzureNetworkNicCreateTask PublicIpAddress(string publicIpAddress = null)
        {
            WithArguments("--public-ip-address");
            if (!string.IsNullOrEmpty(publicIpAddress))
            {
                 WithArguments(publicIpAddress);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkNicCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// The virtual network (VNet) name.
        /// </summary>
        public AzureNetworkNicCreateTask VnetName(string vnetName = null)
        {
            WithArguments("--vnet-name");
            if (!string.IsNullOrEmpty(vnetName))
            {
                 WithArguments(vnetName);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of DNS server IP addresses.
        /// </summary>
        public AzureNetworkNicCreateTask DnsServers(string dnsServers = null)
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
        public AzureNetworkNicCreateTask InternalDnsName(string internalDnsName = null)
        {
            WithArguments("--internal-dns-name");
            if (!string.IsNullOrEmpty(internalDnsName))
            {
                 WithArguments(internalDnsName);
            }

            return this;
        }
     }
}
