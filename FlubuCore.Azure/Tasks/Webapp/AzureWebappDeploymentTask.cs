
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeploymentTask : ExternalProcessTaskBase<AzureWebappDeploymentTask>
     {
        
        /// <summary>
        /// Manage web app deployments.
        /// </summary>
        public AzureWebappDeploymentTask()
        {
            WithArguments("az webapp deployment");
        }

        protected override string Description { get; set; }
        
     }
}
