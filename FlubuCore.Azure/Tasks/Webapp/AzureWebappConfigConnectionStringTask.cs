
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigConnectionStringTask : ExternalProcessTaskBase<AzureWebappConfigConnectionStringTask>
     {
        
        /// <summary>
        /// Manage a web app's connection strings.
        /// </summary>
        public AzureWebappConfigConnectionStringTask()
        {
            WithArguments("az webapp config connection-string");
        }

        protected override string Description { get; set; }
        
     }
}
