
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigBackupTask : ExternalProcessTaskBase<AzureWebappConfigBackupTask>
     {
        
        /// <summary>
        /// Manage backups for web apps.
        /// </summary>
        public AzureWebappConfigBackupTask()
        {
            WithArguments("az webapp config backup");
        }

        protected override string Description { get; set; }
        
     }
}
