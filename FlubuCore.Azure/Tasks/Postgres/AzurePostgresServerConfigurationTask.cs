
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Postgres
{
     public partial class AzurePostgresServerConfigurationTask : ExternalProcessTaskBase<AzurePostgresServerConfigurationTask>
     {
        
        /// <summary>
        /// Manage configuration values for a server.
        /// </summary>
        public AzurePostgresServerConfigurationTask()
        {
            WithArguments("az postgres server configuration");
        }

        protected override string Description { get; set; }
        
     }
}
