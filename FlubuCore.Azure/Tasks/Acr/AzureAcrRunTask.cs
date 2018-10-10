
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrRunTask : ExternalProcessTaskBase<AzureAcrRunTask>
     {
        
        /// <summary>
        /// Queues a quick run providing streamed logs for an Azure Container Registry.
        /// </summary>
        public AzureAcrRunTask(string registry = null)
        {
            WithArguments("az acr run");
WithArguments("--registry");
            if (!string.IsNullOrEmpty(registry))
            {
                 WithArguments(registry);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The task template/definition file path relative to the source context.
        /// </summary>
        public AzureAcrRunTask File(string file = null)
        {
            WithArguments("--file");
            if (!string.IsNullOrEmpty(file))
            {
                 WithArguments(file);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether the logs should be displayed in raw format.
        /// </summary>
        public AzureAcrRunTask NoFormat(string noFormat = null)
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
        public AzureAcrRunTask NoLogs(string noLogs = null)
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
        public AzureAcrRunTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// The operating system type required for the build.
        /// </summary>
        public AzureAcrRunTask Os(string os = null)
        {
            WithArguments("--os");
            if (!string.IsNullOrEmpty(os))
            {
                 WithArguments(os);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureAcrRunTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Value in 'name[=value]' format.
        /// </summary>
        public AzureAcrRunTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }

        /// <summary>
        /// The timeout in seconds.
        /// </summary>
        public AzureAcrRunTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// The task values file path relative to the source context.
        /// </summary>
        public AzureAcrRunTask Values(string values = null)
        {
            WithArguments("--values");
            if (!string.IsNullOrEmpty(values))
            {
                 WithArguments(values);
            }

            return this;
        }
     }
}
