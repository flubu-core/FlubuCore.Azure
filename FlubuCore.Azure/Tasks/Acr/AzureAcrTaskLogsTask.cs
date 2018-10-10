
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrTaskLogsTask : ExternalProcessTaskBase<AzureAcrTaskLogsTask>
     {
        
        /// <summary>
        /// Show logs for a particular run. If no run-id is supplied, show logs for the last created run.
        /// </summary>
        public AzureAcrTaskLogsTask(string registry = null)
        {
            WithArguments("az acr task logs");
WithArguments("--registry");
            if (!string.IsNullOrEmpty(registry))
            {
                 WithArguments(registry);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.
        /// </summary>
        public AzureAcrTaskLogsTask Image(string image = null)
        {
            WithArguments("--image");
            if (!string.IsNullOrEmpty(image))
            {
                 WithArguments(image);
            }

            return this;
        }

        /// <summary>
        /// The name of the task.
        /// </summary>
        public AzureAcrTaskLogsTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureAcrTaskLogsTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// The unique run identifier.
        /// </summary>
        public AzureAcrTaskLogsTask RunId(string runId = null)
        {
            WithArguments("--run-id");
            if (!string.IsNullOrEmpty(runId))
            {
                 WithArguments(runId);
            }

            return this;
        }
     }
}
