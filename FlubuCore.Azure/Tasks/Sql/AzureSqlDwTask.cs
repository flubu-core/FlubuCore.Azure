
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDwTask : ExternalProcessTaskBase<AzureSqlDwTask>
     {
        
        /// <summary>
        /// Manage data warehouses.
        /// </summary>
        public AzureSqlDwTask()
        {
            WithArguments("az sql dw");
        }

        protected override string Description { get; set; }
        
     }
}
