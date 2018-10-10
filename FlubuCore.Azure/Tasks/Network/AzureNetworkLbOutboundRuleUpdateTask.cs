
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbOutboundRuleUpdateTask : ExternalProcessTaskBase<AzureNetworkLbOutboundRuleUpdateTask>
     {
        
        /// <summary>
        /// Update an outbound-rule.
        /// </summary>
        public AzureNetworkLbOutboundRuleUpdateTask(string lbName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network lb outbound-rule update");
WithArguments("--lb-name");
            if (!string.IsNullOrEmpty(lbName))
            {
                 WithArguments(lbName);
            }

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
        /// Name or ID of the backend address pool.
        /// </summary>
        public AzureNetworkLbOutboundRuleUpdateTask AddressPool(string addressPool = null)
        {
            WithArguments("--address-pool");
            if (!string.IsNullOrEmpty(addressPool))
            {
                 WithArguments(addressPool);
            }

            return this;
        }

        /// <summary>
        /// Receive bidirectional TCP reset on TCP flow idle timeout or unexpected connection termination. Only used when protocol is set to TCP.
        /// </summary>
        public AzureNetworkLbOutboundRuleUpdateTask EnableTcpReset(string enableTcpReset = null)
        {
            WithArguments("--enable-tcp-reset");
            if (!string.IsNullOrEmpty(enableTcpReset))
            {
                 WithArguments(enableTcpReset);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of frontend IP configuration names or IDs.
        /// </summary>
        public AzureNetworkLbOutboundRuleUpdateTask FrontendIpConfigs(string frontendIpConfigs = null)
        {
            WithArguments("--frontend-ip-configs");
            if (!string.IsNullOrEmpty(frontendIpConfigs))
            {
                 WithArguments(frontendIpConfigs);
            }

            return this;
        }

        /// <summary>
        /// Idle timeout in minutes.
        /// </summary>
        public AzureNetworkLbOutboundRuleUpdateTask IdleTimeout(string idleTimeout = null)
        {
            WithArguments("--idle-timeout");
            if (!string.IsNullOrEmpty(idleTimeout))
            {
                 WithArguments(idleTimeout);
            }

            return this;
        }

        /// <summary>
        /// The number of outbound ports to be used for NAT.
        /// </summary>
        public AzureNetworkLbOutboundRuleUpdateTask OutboundPorts(string outboundPorts = null)
        {
            WithArguments("--outbound-ports");
            if (!string.IsNullOrEmpty(outboundPorts))
            {
                 WithArguments(outboundPorts);
            }

            return this;
        }

        /// <summary>
        /// Network transport protocol.
        /// </summary>
        public AzureNetworkLbOutboundRuleUpdateTask Protocol(string protocol = null)
        {
            WithArguments("--protocol");
            if (!string.IsNullOrEmpty(protocol))
            {
                 WithArguments(protocol);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkLbOutboundRuleUpdateTask Add(string add = null)
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
        public AzureNetworkLbOutboundRuleUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkLbOutboundRuleUpdateTask Remove(string remove = null)
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
        public AzureNetworkLbOutboundRuleUpdateTask Set(string set = null)
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
