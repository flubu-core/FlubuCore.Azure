
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mysql
{
     public partial class AzureMysqlDbTask : ExternalProcessTaskBase<AzureMysqlDbTask>
     {
        
        /// <summary>
        /// Manage MySQL databases on a server.
        /// </summary>
        public AzureMysqlDbTask()
        {
            WithArguments("az mysql db");
        }

        protected override string Description { get; set; }
        
     }
}
