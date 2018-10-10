
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbRuleUpdateTask : ExternalProcessTaskBase<AzureNetworkLbRuleUpdateTask>
     {
        
        /// <summary>
        /// Update a load balancing rule.
        /// </summary>
        public AzureNetworkLbRuleUpdateTask(string lbName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network lb rule update");
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
        /// The name of the backend address pool.
        /// </summary>
        public AzureNetworkLbRuleUpdateTask BackendPoolName(string backendPoolName = null)
        {
            WithArguments("--backend-pool-name");
            if (!string.IsNullOrEmpty(backendPoolName))
            {
                 WithArguments(backendPoolName);
            }

            return this;
        }

        /// <summary>
        /// Port number.
        /// </summary>
        public AzureNetworkLbRuleUpdateTask BackendPort(string backendPort = null)
        {
            WithArguments("--backend-port");
            if (!string.IsNullOrEmpty(backendPort))
            {
                 WithArguments(backendPort);
            }

            return this;
        }

        /// <summary>
        /// Configures SNAT for the VMs in the backend pool to use the publicIP address specified in the frontend of the load balancing rule.
        /// </summary>
        public AzureNetworkLbRuleUpdateTask DisableOutboundSnat(string disableOutboundSnat = null)
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
        public AzureNetworkLbRuleUpdateTask EnableTcpReset(string enableTcpReset = null)
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
        public AzureNetworkLbRuleUpdateTask FloatingIp(string floatingIp = null)
        {
            WithArguments("--floating-ip");
            if (!string.IsNullOrEmpty(floatingIp))
            {
                 WithArguments(floatingIp);
            }

            return this;
        }

        /// <summary>
        /// The name of the frontend IP configuration.
        /// </summary>
        public AzureNetworkLbRuleUpdateTask FrontendIpName(string frontendIpName = null)
        {
            WithArguments("--frontend-ip-name");
            if (!string.IsNullOrEmpty(frontendIpName))
            {
                 WithArguments(frontendIpName);
            }

            return this;
        }

        /// <summary>
        /// Port number.
        /// </summary>
        public AzureNetworkLbRuleUpdateTask FrontendPort(string frontendPort = null)
        {
            WithArguments("--frontend-port");
            if (!string.IsNullOrEmpty(frontendPort))
            {
                 WithArguments(frontendPort);
            }

            return this;
        }

        /// <summary>
        /// Idle timeout in minutes.
        /// </summary>
        public AzureNetworkLbRuleUpdateTask IdleTimeout(string idleTimeout = null)
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
        public AzureNetworkLbRuleUpdateTask LoadDistribution(string loadDistribution = null)
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
        public AzureNetworkLbRuleUpdateTask ProbeName(string probeName = null)
        {
            WithArguments("--probe-name");
            if (!string.IsNullOrEmpty(probeName))
            {
                 WithArguments(probeName);
            }

            return this;
        }

        /// <summary>
        /// Network transport protocol.
        /// </summary>
        public AzureNetworkLbRuleUpdateTask Protocol(string protocol = null)
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
        public AzureNetworkLbRuleUpdateTask Add(string add = null)
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
        public AzureNetworkLbRuleUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkLbRuleUpdateTask Remove(string remove = null)
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
        public AzureNetworkLbRuleUpdateTask Set(string set = null)
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
