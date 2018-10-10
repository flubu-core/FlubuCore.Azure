
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbInboundNatRuleCreateTask : ExternalProcessTaskBase<AzureNetworkLbInboundNatRuleCreateTask>
     {
        
        /// <summary>
        /// Create an inbound NAT rule.
        /// </summary>
        public AzureNetworkLbInboundNatRuleCreateTask(string backendPort = null ,  string frontendPort = null ,  string lbName = null ,  string name = null ,  string protocol = null ,  string resourceGroup = null)
        {
            WithArguments("az network lb inbound-nat-rule create");
WithArguments("--backend-port");
            if (!string.IsNullOrEmpty(backendPort))
            {
                 WithArguments(backendPort);
            }

WithArguments("--frontend-port");
            if (!string.IsNullOrEmpty(frontendPort))
            {
                 WithArguments(frontendPort);
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
        public AzureNetworkLbInboundNatRuleCreateTask EnableTcpReset(string enableTcpReset = null)
        {
            WithArguments("--enable-tcp-reset");
            if (!string.IsNullOrEmpty(enableTcpReset))
            {
                 WithArguments(enableTcpReset);
            }

            return this;
        }

        /// <summary>
        /// Enable floating IP.
        /// </summary>
        public AzureNetworkLbInboundNatRuleCreateTask FloatingIp(string floatingIp = null)
        {
            WithArguments("--floating-ip");
            if (!string.IsNullOrEmpty(floatingIp))
            {
                 WithArguments(floatingIp);
            }

            return this;
        }

        /// <summary>
        /// The name of the frontend IP configuration. If only one exists, omit to use as default.
        /// </summary>
        public AzureNetworkLbInboundNatRuleCreateTask FrontendIpName(string frontendIpName = null)
        {
            WithArguments("--frontend-ip-name");
            if (!string.IsNullOrEmpty(frontendIpName))
            {
                 WithArguments(frontendIpName);
            }

            return this;
        }

        /// <summary>
        /// Idle timeout in minutes.
        /// </summary>
        public AzureNetworkLbInboundNatRuleCreateTask IdleTimeout(string idleTimeout = null)
        {
            WithArguments("--idle-timeout");
            if (!string.IsNullOrEmpty(idleTimeout))
            {
                 WithArguments(idleTimeout);
            }

            return this;
        }
     }
}
