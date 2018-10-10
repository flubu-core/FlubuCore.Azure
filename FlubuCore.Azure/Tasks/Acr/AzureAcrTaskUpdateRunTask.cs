
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrTaskUpdateRunTask : ExternalProcessTaskBase<AzureAcrTaskUpdateRunTask>
     {
        
        /// <summary>
        /// Patch the run properties of an Azure Container Registry Task.
        /// </summary>
        public AzureAcrTaskUpdateRunTask(string registry = null ,  string runId = null)
        {
            WithArguments("az acr task update-run");
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
        /// Indicates whether the run should be archived.
        /// </summary>
        public AzureAcrTaskUpdateRunTask NoArchive(string noArchive = null)
        {
            WithArguments("--no-archive");
            if (!string.IsNullOrEmpty(noArchive))
            {
                 WithArguments(noArchive);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureAcrTaskUpdateRunTask ResourceGroup(string resourceGroup = null)
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
