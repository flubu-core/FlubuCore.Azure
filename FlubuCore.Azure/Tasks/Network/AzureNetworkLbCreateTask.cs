
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbCreateTask : ExternalProcessTaskBase<AzureNetworkLbCreateTask>
     {
        
        /// <summary>
        /// Create a load balancer.
        /// </summary>
        public AzureNetworkLbCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network lb create");
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
        /// The name of the backend address pool.
        /// </summary>
        public AzureNetworkLbCreateTask BackendPoolName(string backendPoolName = null)
        {
            WithArguments("--backend-pool-name");
            if (!string.IsNullOrEmpty(backendPoolName))
            {
                 WithArguments(backendPoolName);
            }

            return this;
        }

        /// <summary>
        /// The name of the frontend IP configuration.
        /// </summary>
        public AzureNetworkLbCreateTask FrontendIpName(string frontendIpName = null)
        {
            WithArguments("--frontend-ip-name");
            if (!string.IsNullOrEmpty(frontendIpName))
            {
                 WithArguments(frontendIpName);
            }

            return this;
        }

        /// <summary>
        /// Used to create internal facing Load balancer.
        /// </summary>
        public AzureNetworkLbCreateTask FrontendIpZone(string frontendIpZone = null)
        {
            WithArguments("--frontend-ip-zone");
            if (!string.IsNullOrEmpty(frontendIpZone))
            {
                 WithArguments(frontendIpZone);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkLbCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkLbCreateTask NoWait(string noWait = null)
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
        public AzureNetworkLbCreateTask PrivateIpAddress(string privateIpAddress = null)
        {
            WithArguments("--private-ip-address");
            if (!string.IsNullOrEmpty(privateIpAddress))
            {
                 WithArguments(privateIpAddress);
            }

            return this;
        }

        /// <summary>
        /// Load balancer SKU.
        /// </summary>
        public AzureNetworkLbCreateTask Sku(string sku = null)
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
        public AzureNetworkLbCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Generate and validate the ARM template without creating any resources.
        /// </summary>
        public AzureNetworkLbCreateTask Validate(string validate = null)
        {
            WithArguments("--validate");
            if (!string.IsNullOrEmpty(validate))
            {
                 WithArguments(validate);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the public IP address, or "" for none. Uses existing resource if available or will create a new resource with defaults if omitted.
        /// </summary>
        public AzureNetworkLbCreateTask PublicIpAddress(string publicIpAddress = null)
        {
            WithArguments("--public-ip-address");
            if (!string.IsNullOrEmpty(publicIpAddress))
            {
                 WithArguments(publicIpAddress);
            }

            return this;
        }

        /// <summary>
        /// IP allocation method.
        /// </summary>
        public AzureNetworkLbCreateTask PublicIpAddressAllocation(string publicIpAddressAllocation = null)
        {
            WithArguments("--public-ip-address-allocation");
            if (!string.IsNullOrEmpty(publicIpAddressAllocation))
            {
                 WithArguments(publicIpAddressAllocation);
            }

            return this;
        }

        /// <summary>
        /// Globally unique DNS name for a new public IP.
        /// </summary>
        public AzureNetworkLbCreateTask PublicIpDnsName(string publicIpDnsName = null)
        {
            WithArguments("--public-ip-dns-name");
            if (!string.IsNullOrEmpty(publicIpDnsName))
            {
                 WithArguments(publicIpDnsName);
            }

            return this;
        }

        /// <summary>
        /// Used to created a new public ip for the load balancer, a.k.a public facing Load balancer.
        /// </summary>
        public AzureNetworkLbCreateTask PublicIpZone(string publicIpZone = null)
        {
            WithArguments("--public-ip-zone");
            if (!string.IsNullOrEmpty(publicIpZone))
            {
                 WithArguments(publicIpZone);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of a subnet. Uses existing resource or creates new if specified, or none if omitted. If name specified, also specify --vnet-name.
        /// </summary>
        public AzureNetworkLbCreateTask Subnet(string subnet = null)
        {
            WithArguments("--subnet");
            if (!string.IsNullOrEmpty(subnet))
            {
                 WithArguments(subnet);
            }

            return this;
        }

        /// <summary>
        /// The CIDR address prefix to use when creating a new subnet.
        /// </summary>
        public AzureNetworkLbCreateTask SubnetAddressPrefix(string subnetAddressPrefix = null)
        {
            WithArguments("--subnet-address-prefix");
            if (!string.IsNullOrEmpty(subnetAddressPrefix))
            {
                 WithArguments(subnetAddressPrefix);
            }

            return this;
        }

        /// <summary>
        /// The CIDR address prefix to use when creating a new VNet.
        /// </summary>
        public AzureNetworkLbCreateTask VnetAddressPrefix(string vnetAddressPrefix = null)
        {
            WithArguments("--vnet-address-prefix");
            if (!string.IsNullOrEmpty(vnetAddressPrefix))
            {
                 WithArguments(vnetAddressPrefix);
            }

            return this;
        }

        /// <summary>
        /// The virtual network (VNet) name.
        /// </summary>
        public AzureNetworkLbCreateTask VnetName(string vnetName = null)
        {
            WithArguments("--vnet-name");
            if (!string.IsNullOrEmpty(vnetName))
            {
                 WithArguments(vnetName);
            }

            return this;
        }
     }
}
