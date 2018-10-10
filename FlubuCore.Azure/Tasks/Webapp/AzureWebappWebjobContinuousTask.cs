
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappWebjobContinuousTask : ExternalProcessTaskBase<AzureWebappWebjobContinuousTask>
     {
        
        /// <summary>
        /// Allows management operations of continuous webjobs on a webapp.
        /// </summary>
        public AzureWebappWebjobContinuousTask()
        {
            WithArguments("az webapp webjob continuous");
        }

        protected override string Description { get; set; }
        
     }
}
