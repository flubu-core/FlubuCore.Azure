
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbThreatPolicyTask : ExternalProcessTaskBase<AzureSqlDbThreatPolicyTask>
     {
        
        /// <summary>
        /// Manage a database's threat detection policies.
        /// </summary>
        public AzureSqlDbThreatPolicyTask()
        {
            WithArguments("az sql db threat-policy");
        }

        protected override string Description { get; set; }
        
     }
}
