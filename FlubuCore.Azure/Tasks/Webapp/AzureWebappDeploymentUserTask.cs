
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeploymentUserTask : ExternalProcessTaskBase<AzureWebappDeploymentUserTask>
     {
        
        /// <summary>
        /// Manage user credentials for deployment.
        /// </summary>
        public AzureWebappDeploymentUserTask()
        {
            WithArguments("az webapp deployment user");
        }

        protected override string Description { get; set; }
        
     }
}
