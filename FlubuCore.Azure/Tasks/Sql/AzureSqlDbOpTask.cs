
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbOpTask : ExternalProcessTaskBase<AzureSqlDbOpTask>
     {
        
        /// <summary>
        /// Manage operations on a database.
        /// </summary>
        public AzureSqlDbOpTask()
        {
            WithArguments("az sql db op");
        }

        protected override string Description { get; set; }
        
     }
}
