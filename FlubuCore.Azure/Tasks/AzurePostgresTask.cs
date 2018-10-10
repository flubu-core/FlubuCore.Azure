
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzurePostgresTask : ExternalProcessTaskBase<AzurePostgresTask>
     {
        
        /// <summary>
        /// Manage Azure Database for PostgreSQL servers.
        /// </summary>
        public AzurePostgresTask()
        {
            WithArguments("az postgres");
        }

        protected override string Description { get; set; }
        
     }
}
