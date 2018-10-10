
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mariadb
{
     public partial class AzureMariadbServerConfigurationTask : ExternalProcessTaskBase<AzureMariadbServerConfigurationTask>
     {
        
        /// <summary>
        /// Manage configuration values for a server.
        /// </summary>
        public AzureMariadbServerConfigurationTask()
        {
            WithArguments("az mariadb server configuration");
        }

        protected override string Description { get; set; }
        
     }
}
