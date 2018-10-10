
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappWebjobTriggeredTask : ExternalProcessTaskBase<AzureWebappWebjobTriggeredTask>
     {
        
        /// <summary>
        /// Allows management operations of triggered webjobs on a webapp.
        /// </summary>
        public AzureWebappWebjobTriggeredTask()
        {
            WithArguments("az webapp webjob triggered");
        }

        protected override string Description { get; set; }
        
     }
}
