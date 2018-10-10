
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayCreateTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayCreateTask>
     {
        
        /// <summary>
        /// Create an application gateway.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway create");
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
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask Location(string location = null)
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
        public AzureNetworkApplicationGatewayCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask Tags(string tags = null)
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
        public AzureNetworkApplicationGatewayCreateTask Validate(string validate = null)
        {
            WithArguments("--validate");
            if (!string.IsNullOrEmpty(validate))
            {
                 WithArguments(validate);
            }

            return this;
        }

        /// <summary>
        /// The number of instances to use with the application gateway.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask Capacity(string capacity = null)
        {
            WithArguments("--capacity");
            if (!string.IsNullOrEmpty(capacity))
            {
                 WithArguments(capacity);
            }

            return this;
        }

        /// <summary>
        /// The path to the PFX certificate file.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask CertFile(string certFile = null)
        {
            WithArguments("--cert-file");
            if (!string.IsNullOrEmpty(certFile))
            {
                 WithArguments(certFile);
            }

            return this;
        }

        /// <summary>
        /// The certificate password.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask CertPassword(string certPassword = null)
        {
            WithArguments("--cert-password");
            if (!string.IsNullOrEmpty(certPassword))
            {
                 WithArguments(certPassword);
            }

            return this;
        }

        /// <summary>
        /// The time in seconds after a backend server is removed during which on open connection remains active. Range: 0 (disabled) to 3600.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask ConnectionDrainingTimeout(string connectionDrainingTimeout = null)
        {
            WithArguments("--connection-draining-timeout");
            if (!string.IsNullOrEmpty(connectionDrainingTimeout))
            {
                 WithArguments(connectionDrainingTimeout);
            }

            return this;
        }

        /// <summary>
        /// The front end port number.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask FrontendPort(string frontendPort = null)
        {
            WithArguments("--frontend-port");
            if (!string.IsNullOrEmpty(frontendPort))
            {
                 WithArguments(frontendPort);
            }

            return this;
        }

        /// <summary>
        /// Enable or disable HTTP settings cookie-based affinity.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask HttpSettingsCookieBasedAffinity(string httpSettingsCookieBasedAffinity = null)
        {
            WithArguments("--http-settings-cookie-based-affinity");
            if (!string.IsNullOrEmpty(httpSettingsCookieBasedAffinity))
            {
                 WithArguments(httpSettingsCookieBasedAffinity);
            }

            return this;
        }

        /// <summary>
        /// The HTTP settings port.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask HttpSettingsPort(string httpSettingsPort = null)
        {
            WithArguments("--http-settings-port");
            if (!string.IsNullOrEmpty(httpSettingsPort))
            {
                 WithArguments(httpSettingsPort);
            }

            return this;
        }

        /// <summary>
        /// The HTTP settings protocol.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask HttpSettingsProtocol(string httpSettingsProtocol = null)
        {
            WithArguments("--http-settings-protocol");
            if (!string.IsNullOrEmpty(httpSettingsProtocol))
            {
                 WithArguments(httpSettingsProtocol);
            }

            return this;
        }

        /// <summary>
        /// Use HTTP2 for the application gateway.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask Http2(string http2 = null)
        {
            WithArguments("--http2");
            if (!string.IsNullOrEmpty(http2))
            {
                 WithArguments(http2);
            }

            return this;
        }

        /// <summary>
        /// The request routing rule type.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask RoutingRuleType(string routingRuleType = null)
        {
            WithArguments("--routing-rule-type");
            if (!string.IsNullOrEmpty(routingRuleType))
            {
                 WithArguments(routingRuleType);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of IP addresses or DNS names corresponding to backend servers.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask Servers(string servers = null)
        {
            WithArguments("--servers");
            if (!string.IsNullOrEmpty(servers))
            {
                 WithArguments(servers);
            }

            return this;
        }

        /// <summary>
        /// The name of the SKU.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }

        /// <summary>
        /// Static private IP address to use.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask PrivateIpAddress(string privateIpAddress = null)
        {
            WithArguments("--private-ip-address");
            if (!string.IsNullOrEmpty(privateIpAddress))
            {
                 WithArguments(privateIpAddress);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of a public IP address. Uses existing resource or creates new if specified, or none if omitted.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask PublicIpAddress(string publicIpAddress = null)
        {
            WithArguments("--public-ip-address");
            if (!string.IsNullOrEmpty(publicIpAddress))
            {
                 WithArguments(publicIpAddress);
            }

            return this;
        }

        /// <summary>
        /// The kind of IP allocation to use when creating a new public IP.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask PublicIpAddressAllocation(string publicIpAddressAllocation = null)
        {
            WithArguments("--public-ip-address-allocation");
            if (!string.IsNullOrEmpty(publicIpAddressAllocation))
            {
                 WithArguments(publicIpAddressAllocation);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the subnet. Will create resource if it does not exist. If name specified, also specify --vnet-name.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask Subnet(string subnet = null)
        {
            WithArguments("--subnet");
            if (!string.IsNullOrEmpty(subnet))
            {
                 WithArguments(subnet);
            }

            return this;
        }

        /// <summary>
        /// The CIDR prefix to use when creating a new subnet.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask SubnetAddressPrefix(string subnetAddressPrefix = null)
        {
            WithArguments("--subnet-address-prefix");
            if (!string.IsNullOrEmpty(subnetAddressPrefix))
            {
                 WithArguments(subnetAddressPrefix);
            }

            return this;
        }

        /// <summary>
        /// The CIDR prefix to use when creating a new VNet.
        /// </summary>
        public AzureNetworkApplicationGatewayCreateTask VnetAddressPrefix(string vnetAddressPrefix = null)
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
        public AzureNetworkApplicationGatewayCreateTask VnetName(string vnetName = null)
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
