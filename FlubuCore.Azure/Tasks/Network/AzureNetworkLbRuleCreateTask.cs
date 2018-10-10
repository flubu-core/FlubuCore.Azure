
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbRuleCreateTask : ExternalProcessTaskBase<AzureNetworkLbRuleCreateTask>
     {
        
        /// <summary>
        /// Create a load balancing rule.
        /// </summary>
        public AzureNetworkLbRuleCreateTask(string backendPort = null ,  string frontendPort = null ,  string lbName = null ,  string name = null ,  string protocol = null ,  string resourceGroup = null)
        {
            WithArguments("az network lb rule create");
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
        /// The name of the backend address pool. If only one exists, omit to use as default.
        /// </summary>
        public AzureNetworkLbRuleCreateTask BackendPoolName(string backendPoolName = null)
        {
            WithArguments("--backend-pool-name");
            if (!string.IsNullOrEmpty(backendPoolName))
            {
                 WithArguments(backendPoolName);
            }

            return this;
        }

        /// <summary>
        /// Configures SNAT for the VMs in the backend pool to use the publicIP address specified in the frontend of the load balancing rule.
        /// </summary>
        public AzureNetworkLbRuleCreateTask DisableOutboundSnat(string disableOutboundSnat = null)
        {
            WithArguments("--disable-outbound-snat");
            if (!string.IsNullOrEmpty(disableOutboundSnat))
            {
                 WithArguments(disableOutboundSnat);
            }

            return this;
        }

        /// <summary>
        /// Receive bidirectional TCP reset on TCP flow idle timeout or unexpected connection termination. Only used when protocol is set to TCP.
        /// </summary>
        public AzureNetworkLbRuleCreateTask EnableTcpReset(string enableTcpReset = null)
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
        public AzureNetworkLbRuleCreateTask FloatingIp(string floatingIp = null)
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
        public AzureNetworkLbRuleCreateTask FrontendIpName(string frontendIpName = null)
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
        public AzureNetworkLbRuleCreateTask IdleTimeout(string idleTimeout = null)
        {
            WithArguments("--idle-timeout");
            if (!string.IsNullOrEmpty(idleTimeout))
            {
                 WithArguments(idleTimeout);
            }

            return this;
        }

        /// <summary>
        /// Affinity rule settings.
        /// </summary>
        public AzureNetworkLbRuleCreateTask LoadDistribution(string loadDistribution = null)
        {
            WithArguments("--load-distribution");
            if (!string.IsNullOrEmpty(loadDistribution))
            {
                 WithArguments(loadDistribution);
            }

            return this;
        }

        /// <summary>
        /// Name of an existing probe to associate with this rule.
        /// </summary>
        public AzureNetworkLbRuleCreateTask ProbeName(string probeName = null)
        {
            WithArguments("--probe-name");
            if (!string.IsNullOrEmpty(probeName))
            {
                 WithArguments(probeName);
            }

            return this;
        }
     }
}
