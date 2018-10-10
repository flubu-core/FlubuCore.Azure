
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNicIpConfigInboundNatRuleRemoveTask : ExternalProcessTaskBase<AzureNetworkNicIpConfigInboundNatRuleRemoveTask>
     {
        
        /// <summary>
        /// Remove an inbound NAT rule of an IP configuration.
        /// </summary>
        public AzureNetworkNicIpConfigInboundNatRuleRemoveTask(string inboundNatRule = null ,  string ipConfigName = null ,  string nicName = null ,  string resourceGroup = null)
        {
            WithArguments("az network nic ip-config inbound-nat-rule remove");
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
        public AzureNetworkNicIpConfigInboundNatRuleRemoveTask LbName(string lbName = null)
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
