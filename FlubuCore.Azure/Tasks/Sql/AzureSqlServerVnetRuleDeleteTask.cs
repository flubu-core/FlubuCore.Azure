
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerVnetRuleDeleteTask : ExternalProcessTaskBase<AzureSqlServerVnetRuleDeleteTask>
     {
        
        /// <summary>
        /// Deletes the virtual network rule with the given name.
        /// </summary>
        public AzureSqlServerVnetRuleDeleteTask(string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql server vnet-rule delete");
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
        
     }
}
