
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappTrafficRoutingClearTask : ExternalProcessTaskBase<AzureWebappTrafficRoutingClearTask>
     {
        
        /// <summary>
        /// Clear the routing rules and send all traffic to production.
        /// </summary>
        public AzureWebappTrafficRoutingClearTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp traffic-routing clear");
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
