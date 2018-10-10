
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureDeploymentTask : ExternalProcessTaskBase<AzureDeploymentTask>
     {
        
        /// <summary>
        /// Manage Azure Resource Manager deployments at subscription scope.
        /// </summary>
        public AzureDeploymentTask()
        {
            WithArguments("az deployment");
        }

        protected override string Description { get; set; }
        
     }
}
