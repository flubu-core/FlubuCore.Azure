
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mariadb
{
     public partial class AzureMariadbDbTask : ExternalProcessTaskBase<AzureMariadbDbTask>
     {
        
        /// <summary>
        /// Manage MariaDB databases on a server.
        /// </summary>
        public AzureMariadbDbTask()
        {
            WithArguments("az mariadb db");
        }

        protected override string Description { get; set; }
        
     }
}
