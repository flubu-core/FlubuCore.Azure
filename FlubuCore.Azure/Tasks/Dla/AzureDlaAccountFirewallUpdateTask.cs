
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaAccountFirewallUpdateTask : ExternalProcessTaskBase<AzureDlaAccountFirewallUpdateTask>
     {
        
        /// <summary>
        /// Update a firewall rule in a Data Lake Analytics account.
        /// </summary>
        public AzureDlaAccountFirewallUpdateTask(string account = null ,  string firewallRuleName = null)
        {
            WithArguments("az dla account firewall update");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--firewall-rule-name");
            if (!string.IsNullOrEmpty(firewallRuleName))
            {
                 WithArguments(firewallRuleName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.
        /// </summary>
        public AzureDlaAccountFirewallUpdateTask EndIpAddress(string endIpAddress = null)
        {
            WithArguments("--end-ip-address");
            if (!string.IsNullOrEmpty(endIpAddress))
            {
                 WithArguments(endIpAddress);
            }

            return this;
        }

        /// <summary>
        /// If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.
        /// </summary>
        public AzureDlaAccountFirewallUpdateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.
        /// </summary>
        public AzureDlaAccountFirewallUpdateTask StartIpAddress(string startIpAddress = null)
        {
            WithArguments("--start-ip-address");
            if (!string.IsNullOrEmpty(startIpAddress))
            {
                 WithArguments(startIpAddress);
            }

            return this;
        }
     }
}
