
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsAccountFirewallDeleteTask : ExternalProcessTaskBase<AzureDlsAccountFirewallDeleteTask>
     {
        
        /// <summary>
        /// Deletes a firewall rule in a Data Lake Store account.
        /// </summary>
        public AzureDlsAccountFirewallDeleteTask(string account = null ,  string firewallRuleName = null)
        {
            WithArguments("az dls account firewall delete");
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
        /// If not specified, will attempt to discover the resource group for the specified Data Lake Store account.
        /// </summary>
        public AzureDlsAccountFirewallDeleteTask ResourceGroup(string resourceGroup = null)
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
