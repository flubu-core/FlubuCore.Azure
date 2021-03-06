
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mariadb
{
     public partial class AzureMariadbServerFirewallRuleCreateTask : ExternalProcessTaskBase<AzureMariadbServerFirewallRuleCreateTask>
     {
        
        /// <summary>
        /// Create a new firewall rule for a server.
        /// </summary>
        public AzureMariadbServerFirewallRuleCreateTask(string endIpAddress = null ,  string name = null ,  string resourceGroup = null ,  string serverName = null ,  string startIpAddress = null)
        {
            WithArguments("az mariadb server firewall-rule create");
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

WithArguments("--server-name");
            if (!string.IsNullOrEmpty(serverName))
            {
                 WithArguments(serverName);
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
