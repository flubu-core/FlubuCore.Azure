
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mysql
{
     public partial class AzureMysqlServerLogsTask : ExternalProcessTaskBase<AzureMysqlServerLogsTask>
     {
        
        /// <summary>
        /// Manage server logs.
        /// </summary>
        public AzureMysqlServerLogsTask()
        {
            WithArguments("az mysql server-logs");
        }

        protected override string Description { get; set; }
        
     }
}
