
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaAccountFirewallCreateTask : ExternalProcessTaskBase<AzureDlaAccountFirewallCreateTask>
     {
        
        /// <summary>
        /// Create a firewall rule in a Data Lake Analytics account.
        /// </summary>
        public AzureDlaAccountFirewallCreateTask(string account = null ,  string endIpAddress = null ,  string firewallRuleName = null ,  string startIpAddress = null)
        {
            WithArguments("az dla account firewall create");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--end-ip-address");
            if (!string.IsNullOrEmpty(endIpAddress))
            {
                 WithArguments(endIpAddress);
            }

WithArguments("--firewall-rule-name");
            if (!string.IsNullOrEmpty(firewallRuleName))
            {
                 WithArguments(firewallRuleName);
            }

WithArguments("--start-ip-address");
            if (!string.IsNullOrEmpty(startIpAddress))
            {
                 WithArguments(startIpAddress);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.
        /// </summary>
        public AzureDlaAccountFirewallCreateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }
     }
}
