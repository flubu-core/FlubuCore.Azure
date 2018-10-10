
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Postgres
{
     public partial class AzurePostgresServerLogsTask : ExternalProcessTaskBase<AzurePostgresServerLogsTask>
     {
        
        /// <summary>
        /// Manage server logs.
        /// </summary>
        public AzurePostgresServerLogsTask()
        {
            WithArguments("az postgres server-logs");
        }

        protected override string Description { get; set; }
        
     }
}
