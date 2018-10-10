
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbOutboundRuleCreateTask : ExternalProcessTaskBase<AzureNetworkLbOutboundRuleCreateTask>
     {
        
        /// <summary>
        /// Create an outbound-rule.
        /// </summary>
        public AzureNetworkLbOutboundRuleCreateTask(string addressPool = null ,  string frontendIpConfigs = null ,  string lbName = null ,  string name = null ,  string protocol = null ,  string resourceGroup = null)
        {
            WithArguments("az network lb outbound-rule create");
WithArguments("--address-pool");
            if (!string.IsNullOrEmpty(addressPool))
            {
                 WithArguments(addressPool);
            }

WithArguments("--frontend-ip-configs");
            if (!string.IsNullOrEmpty(frontendIpConfigs))
            {
                 WithArguments(frontendIpConfigs);
            }

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

WithArguments("--protocol");
            if (!string.IsNullOrEmpty(protocol))
            {
                 WithArguments(protocol);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Receive bidirectional TCP reset on TCP flow idle timeout or unexpected connection termination. Only used when protocol is set to TCP.
        /// </summary>
        public AzureNetworkLbOutboundRuleCreateTask EnableTcpReset(string enableTcpReset = null)
        {
            WithArguments("--enable-tcp-reset");
            if (!string.IsNullOrEmpty(enableTcpReset))
            {
                 WithArguments(enableTcpReset);
            }

            return this;
        }

        /// <summary>
        /// Idle timeout in minutes.
        /// </summary>
        public AzureNetworkLbOutboundRuleCreateTask IdleTimeout(string idleTimeout = null)
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
        public AzureNetworkLbOutboundRuleCreateTask OutboundPorts(string outboundPorts = null)
        {
            WithArguments("--outbound-ports");
            if (!string.IsNullOrEmpty(outboundPorts))
            {
                 WithArguments(outboundPorts);
            }

            return this;
        }
     }
}
