
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappDeploymentSourceUpdateTokenTask : ExternalProcessTaskBase<AzureFunctionappDeploymentSourceUpdateTokenTask>
     {
        
        /// <summary>
        /// Update source control token cached in Azure app service.
        /// </summary>
        public AzureFunctionappDeploymentSourceUpdateTokenTask()
        {
            WithArguments("az functionapp deployment source update-token");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Git access token required for auto sync.
        /// </summary>
        public AzureFunctionappDeploymentSourceUpdateTokenTask GitToken(string gitToken = null)
        {
            WithArguments("--git-token");
            if (!string.IsNullOrEmpty(gitToken))
            {
                 WithArguments(gitToken);
            }

            return this;
        }
     }
}
