
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappCorsTask : ExternalProcessTaskBase<AzureWebappCorsTask>
     {
        
        /// <summary>
        /// Manage Cross-Origin Resource Sharing (CORS).
        /// </summary>
        public AzureWebappCorsTask()
        {
            WithArguments("az webapp cors");
        }

        protected override string Description { get; set; }
        
     }
}
