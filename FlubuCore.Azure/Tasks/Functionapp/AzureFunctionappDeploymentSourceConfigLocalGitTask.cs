
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappDeploymentSourceConfigLocalGitTask : ExternalProcessTaskBase<AzureFunctionappDeploymentSourceConfigLocalGitTask>
     {
        
        /// <summary>
        /// Get a URL for a git repository endpoint to clone and push to for function app deployment.
        /// </summary>
        public AzureFunctionappDeploymentSourceConfigLocalGitTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az functionapp deployment source config-local-git");
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
