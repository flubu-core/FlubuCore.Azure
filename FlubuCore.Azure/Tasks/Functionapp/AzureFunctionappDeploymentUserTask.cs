
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappDeploymentUserTask : ExternalProcessTaskBase<AzureFunctionappDeploymentUserTask>
     {
        
        /// <summary>
        /// Manage user credentials for deployment.
        /// </summary>
        public AzureFunctionappDeploymentUserTask()
        {
            WithArguments("az functionapp deployment user");
        }

        protected override string Description { get; set; }
        
     }
}
