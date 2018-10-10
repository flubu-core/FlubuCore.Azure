
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrBuildTaskLogsTask : ExternalProcessTaskBase<AzureAcrBuildTaskLogsTask>
     {
        
        /// <summary>
        /// Show logs for a particular build. If no build-id is supplied, display the logs for the last created build.
        /// </summary>
        public AzureAcrBuildTaskLogsTask(string registry = null)
        {
            WithArguments("az acr build-task logs");
WithArguments("--registry");
            if (!string.IsNullOrEmpty(registry))
            {
                 WithArguments(registry);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The unique build identifier.
        /// </summary>
        public AzureAcrBuildTaskLogsTask BuildId(string buildId = null)
        {
            WithArguments("--build-id");
            if (!string.IsNullOrEmpty(buildId))
            {
                 WithArguments(buildId);
            }

            return this;
        }

        /// <summary>
        /// The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.
        /// </summary>
        public AzureAcrBuildTaskLogsTask Image(string image = null)
        {
            WithArguments("--image");
            if (!string.IsNullOrEmpty(image))
            {
                 WithArguments(image);
            }

            return this;
        }

        /// <summary>
        /// The name of the build task.
        /// </summary>
        public AzureAcrBuildTaskLogsTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether the logs should be displayed in raw format.
        /// </summary>
        public AzureAcrBuildTaskLogsTask NoFormat(string noFormat = null)
        {
            WithArguments("--no-format");
            if (!string.IsNullOrEmpty(noFormat))
            {
                 WithArguments(noFormat);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureAcrBuildTaskLogsTask ResourceGroup(string resourceGroup = null)
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
