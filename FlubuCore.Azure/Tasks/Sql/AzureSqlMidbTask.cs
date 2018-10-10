
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlMidbTask : ExternalProcessTaskBase<AzureSqlMidbTask>
     {
        
        /// <summary>
        /// Manage SQL managed instance databases.
        /// </summary>
        public AzureSqlMidbTask()
        {
            WithArguments("az sql midb");
        }

        protected override string Description { get; set; }
        
     }
}
