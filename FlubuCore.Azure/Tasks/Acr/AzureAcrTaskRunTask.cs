
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrTaskRunTask : ExternalProcessTaskBase<AzureAcrTaskRunTask>
     {
        
        /// <summary>
        /// Manually trigger a task that might otherwise be waiting for git commits or base image update triggers.
        /// </summary>
        public AzureAcrTaskRunTask(string name = null ,  string registry = null)
        {
            WithArguments("az acr task run");
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
        /// Do not show logs after successfully queuing the build.
        /// </summary>
        public AzureAcrTaskRunTask NoLogs(string noLogs = null)
        {
            WithArguments("--no-logs");
            if (!string.IsNullOrEmpty(noLogs))
            {
                 WithArguments(noLogs);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the run to complete and return immediately after queuing the run.
        /// </summary>
        public AzureAcrTaskRunTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureAcrTaskRunTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Task value in 'name[=value]' format.
        /// </summary>
        public AzureAcrTaskRunTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }

        /// <summary>
        /// Secret task value in 'name[=value]' format.
        /// </summary>
        public AzureAcrTaskRunTask SetSecret(string setSecret = null)
        {
            WithArguments("--set-secret");
            if (!string.IsNullOrEmpty(setSecret))
            {
                 WithArguments(setSecret);
            }

            return this;
        }
     }
}
