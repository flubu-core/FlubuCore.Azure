
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNicIpConfigInboundNatRuleAddTask : ExternalProcessTaskBase<AzureNetworkNicIpConfigInboundNatRuleAddTask>
     {
        
        /// <summary>
        /// Add an inbound NAT rule to an IP configuration.
        /// </summary>
        public AzureNetworkNicIpConfigInboundNatRuleAddTask(string inboundNatRule = null ,  string ipConfigName = null ,  string nicName = null ,  string resourceGroup = null)
        {
            WithArguments("az network nic ip-config inbound-nat-rule add");
WithArguments("--inbound-nat-rule");
            if (!string.IsNullOrEmpty(inboundNatRule))
            {
                 WithArguments(inboundNatRule);
            }

WithArguments("--ip-config-name");
            if (!string.IsNullOrEmpty(ipConfigName))
            {
                 WithArguments(ipConfigName);
            }

WithArguments("--nic-name");
            if (!string.IsNullOrEmpty(nicName))
            {
                 WithArguments(nicName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The name of the load balancer associated with the NAT rule (Omit if suppying a NAT rule ID).
        /// </summary>
        public AzureNetworkNicIpConfigInboundNatRuleAddTask LbName(string lbName = null)
        {
            WithArguments("--lb-name");
            if (!string.IsNullOrEmpty(lbName))
            {
                 WithArguments(lbName);
            }

            return this;
        }
     }
}
