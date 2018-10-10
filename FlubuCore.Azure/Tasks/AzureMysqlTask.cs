
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureMysqlTask : ExternalProcessTaskBase<AzureMysqlTask>
     {
        
        /// <summary>
        /// Manage Azure Database for MySQL servers.
        /// </summary>
        public AzureMysqlTask()
        {
            WithArguments("az mysql");
        }

        protected override string Description { get; set; }
        
     }
}
