
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappTrafficRoutingSetTask : ExternalProcessTaskBase<AzureWebappTrafficRoutingSetTask>
     {
        
        /// <summary>
        /// Configure routing traffic to deployment slots.
        /// </summary>
        public AzureWebappTrafficRoutingSetTask(string distribution = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp traffic-routing set");
WithArguments("--distribution");
            if (!string.IsNullOrEmpty(distribution))
            {
                 WithArguments(distribution);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
