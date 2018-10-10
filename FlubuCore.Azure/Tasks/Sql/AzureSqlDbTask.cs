
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbTask : ExternalProcessTaskBase<AzureSqlDbTask>
     {
        
        /// <summary>
        /// Manage databases.
        /// </summary>
        public AzureSqlDbTask()
        {
            WithArguments("az sql db");
        }

        protected override string Description { get; set; }
        
     }
}
