
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbInboundNatPoolUpdateTask : ExternalProcessTaskBase<AzureNetworkLbInboundNatPoolUpdateTask>
     {
        
        /// <summary>
        /// Update an inbound NAT address pool.
        /// </summary>
        public AzureNetworkLbInboundNatPoolUpdateTask(string lbName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network lb inbound-nat-pool update");
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
        /// Port number.
        /// </summary>
        public AzureNetworkLbInboundNatPoolUpdateTask BackendPort(string backendPort = null)
        {
            WithArguments("--backend-port");
            if (!string.IsNullOrEmpty(backendPort))
            {
                 WithArguments(backendPort);
            }

            return this;
        }

        /// <summary>
        /// Receive bidirectional TCP reset on TCP flow idle timeout or unexpected connection termination. Only used when protocol is set to TCP.
        /// </summary>
        public AzureNetworkLbInboundNatPoolUpdateTask EnableTcpReset(string enableTcpReset = null)
        {
            WithArguments("--enable-tcp-reset");
            if (!string.IsNullOrEmpty(enableTcpReset))
            {
                 WithArguments(enableTcpReset);
            }

            return this;
        }

        /// <summary>
        /// The name of the frontend IP configuration.
        /// </summary>
        public AzureNetworkLbInboundNatPoolUpdateTask FrontendIpName(string frontendIpName = null)
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
        public AzureNetworkLbInboundNatPoolUpdateTask FrontendPortRangeEnd(string frontendPortRangeEnd = null)
        {
            WithArguments("--frontend-port-range-end");
            if (!string.IsNullOrEmpty(frontendPortRangeEnd))
            {
                 WithArguments(frontendPortRangeEnd);
            }

            return this;
        }

        /// <summary>
        /// Port number.
        /// </summary>
        public AzureNetworkLbInboundNatPoolUpdateTask FrontendPortRangeStart(string frontendPortRangeStart = null)
        {
            WithArguments("--frontend-port-range-start");
            if (!string.IsNullOrEmpty(frontendPortRangeStart))
            {
                 WithArguments(frontendPortRangeStart);
            }

            return this;
        }

        /// <summary>
        /// Network transport protocol.
        /// </summary>
        public AzureNetworkLbInboundNatPoolUpdateTask Protocol(string protocol = null)
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
        public AzureNetworkLbInboundNatPoolUpdateTask Add(string add = null)
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
        public AzureNetworkLbInboundNatPoolUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkLbInboundNatPoolUpdateTask Remove(string remove = null)
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
        public AzureNetworkLbInboundNatPoolUpdateTask Set(string set = null)
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
