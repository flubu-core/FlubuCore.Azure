
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerFirewallRuleCreateTask : ExternalProcessTaskBase<AzureSqlServerFirewallRuleCreateTask>
     {
        
        /// <summary>
        /// Create a firewall rule.
        /// </summary>
        public AzureSqlServerFirewallRuleCreateTask(string endIpAddress = null ,  string name = null ,  string resourceGroup = null ,  string server = null ,  string startIpAddress = null)
        {
            WithArguments("az sql server firewall-rule create");
WithArguments("--end-ip-address");
            if (!string.IsNullOrEmpty(endIpAddress))
            {
                 WithArguments(endIpAddress);
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

WithArguments("--server");
            if (!string.IsNullOrEmpty(server))
            {
                 WithArguments(server);
            }

WithArguments("--start-ip-address");
            if (!string.IsNullOrEmpty(startIpAddress))
            {
                 WithArguments(startIpAddress);
            }

        }

        protected override string Description { get; set; }
        
     }
}
