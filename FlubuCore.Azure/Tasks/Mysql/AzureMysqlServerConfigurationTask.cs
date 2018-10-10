
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mysql
{
     public partial class AzureMysqlServerConfigurationTask : ExternalProcessTaskBase<AzureMysqlServerConfigurationTask>
     {
        
        /// <summary>
        /// Manage configuration values for a server.
        /// </summary>
        public AzureMysqlServerConfigurationTask()
        {
            WithArguments("az mysql server configuration");
        }

        protected override string Description { get; set; }
        
     }
}
