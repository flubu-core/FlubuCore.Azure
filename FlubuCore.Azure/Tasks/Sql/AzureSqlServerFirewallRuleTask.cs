
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerFirewallRuleTask : ExternalProcessTaskBase<AzureSqlServerFirewallRuleTask>
     {
        
        /// <summary>
        /// Manage a server's firewall rules.
        /// </summary>
        public AzureSqlServerFirewallRuleTask()
        {
            WithArguments("az sql server firewall-rule");
        }

        protected override string Description { get; set; }
        
     }
}
