
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureMariadbTask : ExternalProcessTaskBase<AzureMariadbTask>
     {
        
        /// <summary>
        /// Manage Azure Database for MariaDB servers.
        /// </summary>
        public AzureMariadbTask()
        {
            WithArguments("az mariadb");
        }

        protected override string Description { get; set; }
        
     }
}
