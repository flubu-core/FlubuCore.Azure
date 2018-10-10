
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerConnPolicyTask : ExternalProcessTaskBase<AzureSqlServerConnPolicyTask>
     {
        
        /// <summary>
        /// Manage a server's connection policy.
        /// </summary>
        public AzureSqlServerConnPolicyTask()
        {
            WithArguments("az sql server conn-policy");
        }

        protected override string Description { get; set; }
        
     }
}
