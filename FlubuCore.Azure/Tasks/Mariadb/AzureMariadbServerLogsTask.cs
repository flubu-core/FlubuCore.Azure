
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mariadb
{
     public partial class AzureMariadbServerLogsTask : ExternalProcessTaskBase<AzureMariadbServerLogsTask>
     {
        
        /// <summary>
        /// Manage server logs.
        /// </summary>
        public AzureMariadbServerLogsTask()
        {
            WithArguments("az mariadb server-logs");
        }

        protected override string Description { get; set; }
        
     }
}
