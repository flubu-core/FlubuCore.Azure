
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mysql
{
     public partial class AzureMysqlServerFirewallRuleTask : ExternalProcessTaskBase<AzureMysqlServerFirewallRuleTask>
     {
        
        /// <summary>
        /// Manage firewall rules for a server.
        /// </summary>
        public AzureMysqlServerFirewallRuleTask()
        {
            WithArguments("az mysql server firewall-rule");
        }

        protected override string Description { get; set; }
        
     }
}
