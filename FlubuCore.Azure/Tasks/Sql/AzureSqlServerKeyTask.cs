
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerKeyTask : ExternalProcessTaskBase<AzureSqlServerKeyTask>
     {
        
        /// <summary>
        /// Manage a server's keys.
        /// </summary>
        public AzureSqlServerKeyTask()
        {
            WithArguments("az sql server key");
        }

        protected override string Description { get; set; }
        
     }
}
