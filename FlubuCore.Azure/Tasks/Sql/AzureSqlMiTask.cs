
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlMiTask : ExternalProcessTaskBase<AzureSqlMiTask>
     {
        
        /// <summary>
        /// Manage SQL managed instances.
        /// </summary>
        public AzureSqlMiTask()
        {
            WithArguments("az sql mi");
        }

        protected override string Description { get; set; }
        
     }
}
