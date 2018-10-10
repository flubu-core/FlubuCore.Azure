
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Postgres
{
     public partial class AzurePostgresServerFirewallRuleTask : ExternalProcessTaskBase<AzurePostgresServerFirewallRuleTask>
     {
        
        /// <summary>
        /// Manage firewall rules for a server.
        /// </summary>
        public AzurePostgresServerFirewallRuleTask()
        {
            WithArguments("az postgres server firewall-rule");
        }

        protected override string Description { get; set; }
        
     }
}
