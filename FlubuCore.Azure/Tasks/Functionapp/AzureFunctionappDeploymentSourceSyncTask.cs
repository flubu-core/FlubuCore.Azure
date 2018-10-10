
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappDeploymentSourceSyncTask : ExternalProcessTaskBase<AzureFunctionappDeploymentSourceSyncTask>
     {
        
        /// <summary>
        /// Synchronize from the repository. Only needed under manual integration mode.
        /// </summary>
        public AzureFunctionappDeploymentSourceSyncTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az functionapp deployment source sync");
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
