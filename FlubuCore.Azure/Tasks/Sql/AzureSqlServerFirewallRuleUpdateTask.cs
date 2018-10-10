
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerFirewallRuleUpdateTask : ExternalProcessTaskBase<AzureSqlServerFirewallRuleUpdateTask>
     {
        
        /// <summary>
        /// Update a firewall rule.
        /// </summary>
        public AzureSqlServerFirewallRuleUpdateTask(string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql server firewall-rule update");
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

WithArguments("--server");
            if (!string.IsNullOrEmpty(server))
            {
                 WithArguments(server);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.
        /// </summary>
        public AzureSqlServerFirewallRuleUpdateTask EndIpAddress(string endIpAddress = null)
        {
            WithArguments("--end-ip-address");
            if (!string.IsNullOrEmpty(endIpAddress))
            {
                 WithArguments(endIpAddress);
            }

            return this;
        }

        /// <summary>
        /// The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.
        /// </summary>
        public AzureSqlServerFirewallRuleUpdateTask StartIpAddress(string startIpAddress = null)
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
