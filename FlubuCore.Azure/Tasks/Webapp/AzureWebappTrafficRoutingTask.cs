
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappTrafficRoutingTask : ExternalProcessTaskBase<AzureWebappTrafficRoutingTask>
     {
        
        /// <summary>
        /// Manage traffic routing for web apps.
        /// </summary>
        public AzureWebappTrafficRoutingTask()
        {
            WithArguments("az webapp traffic-routing");
        }

        protected override string Description { get; set; }
        
     }
}
