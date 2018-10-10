
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbAuditPolicyTask : ExternalProcessTaskBase<AzureSqlDbAuditPolicyTask>
     {
        
        /// <summary>
        /// Manage a database's auditing policy.
        /// </summary>
        public AzureSqlDbAuditPolicyTask()
        {
            WithArguments("az sql db audit-policy");
        }

        protected override string Description { get; set; }
        
     }
}
