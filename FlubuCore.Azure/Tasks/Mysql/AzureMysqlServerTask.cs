
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mysql
{
     public partial class AzureMysqlServerTask : ExternalProcessTaskBase<AzureMysqlServerTask>
     {
        
        /// <summary>
        /// Manage MySQL servers.
        /// </summary>
        public AzureMysqlServerTask()
        {
            WithArguments("az mysql server");
        }

        protected override string Description { get; set; }
        
     }
}
