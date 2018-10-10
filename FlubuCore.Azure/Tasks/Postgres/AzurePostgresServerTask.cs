
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Postgres
{
     public partial class AzurePostgresServerTask : ExternalProcessTaskBase<AzurePostgresServerTask>
     {
        
        /// <summary>
        /// Manage PostgreSQL servers.
        /// </summary>
        public AzurePostgresServerTask()
        {
            WithArguments("az postgres server");
        }

        protected override string Description { get; set; }
        
     }
}
