
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrBuildTaskUpdateBuildTask : ExternalProcessTaskBase<AzureAcrBuildTaskUpdateBuildTask>
     {
        
        /// <summary>
        /// Patch the build properties of an Azure Container Registry.
        /// </summary>
        public AzureAcrBuildTaskUpdateBuildTask(string buildId = null ,  string registry = null)
        {
            WithArguments("az acr build-task update-build");
WithArguments("--build-id");
            if (!string.IsNullOrEmpty(buildId))
            {
                 WithArguments(buildId);
            }

WithArguments("--registry");
            if (!string.IsNullOrEmpty(registry))
            {
                 WithArguments(registry);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Indicates whether the build should be archived.
        /// </summary>
        public AzureAcrBuildTaskUpdateBuildTask NoArchive(string noArchive = null)
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
        public AzureAcrBuildTaskUpdateBuildTask ResourceGroup(string resourceGroup = null)
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
