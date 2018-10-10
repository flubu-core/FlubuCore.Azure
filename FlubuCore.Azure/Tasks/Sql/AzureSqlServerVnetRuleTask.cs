
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerVnetRuleTask : ExternalProcessTaskBase<AzureSqlServerVnetRuleTask>
     {
        
        /// <summary>
        /// Manage a server's virtual network rules.
        /// </summary>
        public AzureSqlServerVnetRuleTask()
        {
            WithArguments("az sql server vnet-rule");
        }

        protected override string Description { get; set; }
        
     }
}
