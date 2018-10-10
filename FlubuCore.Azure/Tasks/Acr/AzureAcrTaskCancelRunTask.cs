
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrTaskCancelRunTask : ExternalProcessTaskBase<AzureAcrTaskCancelRunTask>
     {
        
        /// <summary>
        /// Cancel a specified run of an Azure Container Registry.
        /// </summary>
        public AzureAcrTaskCancelRunTask(string registry = null ,  string runId = null)
        {
            WithArguments("az acr task cancel-run");
WithArguments("--registry");
            if (!string.IsNullOrEmpty(registry))
            {
                 WithArguments(registry);
            }

WithArguments("--run-id");
            if (!string.IsNullOrEmpty(runId))
            {
                 WithArguments(runId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureAcrTaskCancelRunTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }
     }
}
