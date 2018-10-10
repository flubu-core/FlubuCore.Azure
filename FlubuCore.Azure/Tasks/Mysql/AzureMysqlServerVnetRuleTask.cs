
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mysql
{
     public partial class AzureMysqlServerVnetRuleTask : ExternalProcessTaskBase<AzureMysqlServerVnetRuleTask>
     {
        
        /// <summary>
        /// Manage a server's virtual network rules.
        /// </summary>
        public AzureMysqlServerVnetRuleTask()
        {
            WithArguments("az mysql server vnet-rule");
        }

        protected override string Description { get; set; }
        
     }
}
