
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeploymentSourceSyncTask : ExternalProcessTaskBase<AzureWebappDeploymentSourceSyncTask>
     {
        
        /// <summary>
        /// Synchronize from the repository. Only needed under manual integration mode.
        /// </summary>
        public AzureWebappDeploymentSourceSyncTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp deployment source sync");
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
        
        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappDeploymentSourceSyncTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }
     }
}
