
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeploymentSourceTask : ExternalProcessTaskBase<AzureWebappDeploymentSourceTask>
     {
        
        /// <summary>
        /// Manage web app deployment via source control.
        /// </summary>
        public AzureWebappDeploymentSourceTask()
        {
            WithArguments("az webapp deployment source");
        }

        protected override string Description { get; set; }
        
     }
}
