
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mariadb
{
     public partial class AzureMariadbServerFirewallRuleTask : ExternalProcessTaskBase<AzureMariadbServerFirewallRuleTask>
     {
        
        /// <summary>
        /// Manage firewall rules for a server.
        /// </summary>
        public AzureMariadbServerFirewallRuleTask()
        {
            WithArguments("az mariadb server firewall-rule");
        }

        protected override string Description { get; set; }
        
     }
}
