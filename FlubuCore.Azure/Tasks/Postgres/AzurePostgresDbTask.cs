
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Postgres
{
     public partial class AzurePostgresDbTask : ExternalProcessTaskBase<AzurePostgresDbTask>
     {
        
        /// <summary>
        /// Manage PostgreSQL databases on a server.
        /// </summary>
        public AzurePostgresDbTask()
        {
            WithArguments("az postgres db");
        }

        protected override string Description { get; set; }
        
     }
}
