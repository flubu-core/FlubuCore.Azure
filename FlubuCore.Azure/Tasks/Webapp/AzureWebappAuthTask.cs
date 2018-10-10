
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappAuthTask : ExternalProcessTaskBase<AzureWebappAuthTask>
     {
        
        /// <summary>
        /// Manage webapp authentication and authorization.
        /// </summary>
        public AzureWebappAuthTask()
        {
            WithArguments("az webapp auth");
        }

        protected override string Description { get; set; }
        
     }
}
