
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappDeploymentTask : ExternalProcessTaskBase<AzureFunctionappDeploymentTask>
     {
        
        /// <summary>
        /// Manage function app deployments.
        /// </summary>
        public AzureFunctionappDeploymentTask()
        {
            WithArguments("az functionapp deployment");
        }

        protected override string Description { get; set; }
        
     }
}
