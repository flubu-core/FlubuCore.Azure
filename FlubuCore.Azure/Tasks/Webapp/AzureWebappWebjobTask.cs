
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappWebjobTask : ExternalProcessTaskBase<AzureWebappWebjobTask>
     {
        
        /// <summary>
        /// Allows management operations for webjobs on a webapp.
        /// </summary>
        public AzureWebappWebjobTask()
        {
            WithArguments("az webapp webjob");
        }

        protected override string Description { get; set; }
        
     }
}
