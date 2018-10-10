
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrBuildTaskRunTask : ExternalProcessTaskBase<AzureAcrBuildTaskRunTask>
     {
        
        /// <summary>
        /// Trigger a build task that might otherwise be waiting for git commits or base image update triggers for an Azure Container Registry.
        /// </summary>
        public AzureAcrBuildTaskRunTask(string name = null ,  string registry = null)
        {
            WithArguments("az acr build-task run");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--registry");
            if (!string.IsNullOrEmpty(registry))
            {
                 WithArguments(registry);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Indicates whether the logs should be displayed in raw format.
        /// </summary>
        public AzureAcrBuildTaskRunTask NoFormat(string noFormat = null)
        {
            WithArguments("--no-format");
            if (!string.IsNullOrEmpty(noFormat))
            {
                 WithArguments(noFormat);
            }

            return this;
        }

        /// <summary>
        /// Do not show logs after successfully queuing the build.
        /// </summary>
        public AzureAcrBuildTaskRunTask NoLogs(string noLogs = null)
        {
            WithArguments("--no-logs");
            if (!string.IsNullOrEmpty(noLogs))
            {
                 WithArguments(noLogs);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureAcrBuildTaskRunTask ResourceGroup(string resourceGroup = null)
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
