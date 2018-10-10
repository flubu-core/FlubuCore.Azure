
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeploymentContainerTask : ExternalProcessTaskBase<AzureWebappDeploymentContainerTask>
     {
        
        /// <summary>
        /// Manage container-based continuous deployment.
        /// </summary>
        public AzureWebappDeploymentContainerTask()
        {
            WithArguments("az webapp deployment container");
        }

        protected override string Description { get; set; }
        
     }
}
