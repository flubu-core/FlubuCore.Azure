
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlFailoverGroupTask : ExternalProcessTaskBase<AzureSqlFailoverGroupTask>
     {
        
        /// <summary>
        /// Manage SQL Failover Groups.
        /// </summary>
        public AzureSqlFailoverGroupTask()
        {
            WithArguments("az sql failover-group");
        }

        protected override string Description { get; set; }
        
     }
}
