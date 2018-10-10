
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Postgres
{
     public partial class AzurePostgresServerVnetRuleTask : ExternalProcessTaskBase<AzurePostgresServerVnetRuleTask>
     {
        
        /// <summary>
        /// Manage a server's virtual network rules.
        /// </summary>
        public AzurePostgresServerVnetRuleTask()
        {
            WithArguments("az postgres server vnet-rule");
        }

        protected override string Description { get; set; }
        
     }
}
