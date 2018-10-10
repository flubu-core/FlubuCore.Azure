
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbInboundNatPoolCreateTask : ExternalProcessTaskBase<AzureNetworkLbInboundNatPoolCreateTask>
     {
        
        /// <summary>
        /// Create an inbound NAT address pool.
        /// </summary>
        public AzureNetworkLbInboundNatPoolCreateTask(string backendPort = null ,  string frontendPortRangeEnd = null ,  string frontendPortRangeStart = null ,  string lbName = null ,  string name = null ,  string protocol = null ,  string resourceGroup = null)
        {
            WithArguments("az network lb inbound-nat-pool create");
WithArguments("--backend-port");
            if (!string.IsNullOrEmpty(backendPort))
            {
                 WithArguments(backendPort);
            }

WithArguments("--frontend-port-range-end");
            if (!string.IsNullOrEmpty(frontendPortRangeEnd))
            {
                 WithArguments(frontendPortRangeEnd);
            }

WithArguments("--frontend-port-range-start");
            if (!string.IsNullOrEmpty(frontendPortRangeStart))
            {
                 WithArguments(frontendPortRangeStart);
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
        public AzureNetworkLbInboundNatPoolCreateTask EnableTcpReset(string enableTcpReset = null)
        {
            WithArguments("--enable-tcp-reset");
            if (!string.IsNullOrEmpty(enableTcpReset))
            {
                 WithArguments(enableTcpReset);
            }

            return this;
        }

        /// <summary>
        /// The name of the frontend IP configuration. If only one exists, omit to use as default.
        /// </summary>
        public AzureNetworkLbInboundNatPoolCreateTask FrontendIpName(string frontendIpName = null)
        {
            WithArguments("--frontend-ip-name");
            if (!string.IsNullOrEmpty(frontendIpName))
            {
                 WithArguments(frontendIpName);
            }

            return this;
        }
     }
}
