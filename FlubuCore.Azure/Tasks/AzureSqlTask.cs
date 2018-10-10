
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureSqlTask : ExternalProcessTaskBase<AzureSqlTask>
     {
        
        /// <summary>
        /// Manage Azure SQL Databases and Data Warehouses.
        /// </summary>
        public AzureSqlTask()
        {
            WithArguments("az sql");
        }

        protected override string Description { get; set; }
        
     }
}
