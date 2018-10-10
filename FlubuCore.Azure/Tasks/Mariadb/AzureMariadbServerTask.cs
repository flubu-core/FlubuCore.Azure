
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mariadb
{
     public partial class AzureMariadbServerTask : ExternalProcessTaskBase<AzureMariadbServerTask>
     {
        
        /// <summary>
        /// Manage MariaDB servers.
        /// </summary>
        public AzureMariadbServerTask()
        {
            WithArguments("az mariadb server");
        }

        protected override string Description { get; set; }
        
     }
}
