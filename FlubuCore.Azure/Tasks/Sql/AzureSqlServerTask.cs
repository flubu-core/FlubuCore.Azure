
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerTask : ExternalProcessTaskBase<AzureSqlServerTask>
     {
        
        /// <summary>
        /// Manage SQL servers.
        /// </summary>
        public AzureSqlServerTask()
        {
            WithArguments("az sql server");
        }

        protected override string Description { get; set; }
        
     }
}
