
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrBuildTask : ExternalProcessTaskBase<AzureAcrBuildTask>
     {
        
        /// <summary>
        /// Queues a quick build, providing streamed logs for an Azure Container Registry.
        /// </summary>
        public AzureAcrBuildTask(string registry = null)
        {
            WithArguments("az acr build");
WithArguments("--registry");
            if (!string.IsNullOrEmpty(registry))
            {
                 WithArguments(registry);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Build argument in 'name[=value]' format.
        /// </summary>
        public AzureAcrBuildTask BuildArg(string buildArg = null)
        {
            WithArguments("--build-arg");
            if (!string.IsNullOrEmpty(buildArg))
            {
                 WithArguments(buildArg);
            }

            return this;
        }

        /// <summary>
        /// The relative path of the the docker file to the source code root folder.
        /// </summary>
        public AzureAcrBuildTask File(string file = null)
        {
            WithArguments("--file");
            if (!string.IsNullOrEmpty(file))
            {
                 WithArguments(file);
            }

            return this;
        }

        /// <summary>
        /// The name of the image. May include a tag in the format 'name:tag'.
        /// </summary>
        public AzureAcrBuildTask Image(string image = null)
        {
            WithArguments("--image");
            if (!string.IsNullOrEmpty(image))
            {
                 WithArguments(image);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether the logs should be displayed in raw format.
        /// </summary>
        public AzureAcrBuildTask NoFormat(string noFormat = null)
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
        public AzureAcrBuildTask NoLogs(string noLogs = null)
        {
            WithArguments("--no-logs");
            if (!string.IsNullOrEmpty(noLogs))
            {
                 WithArguments(noLogs);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether the image built should be pushed to the registry.
        /// </summary>
        public AzureAcrBuildTask NoPush(string noPush = null)
        {
            WithArguments("--no-push");
            if (!string.IsNullOrEmpty(noPush))
            {
                 WithArguments(noPush);
            }

            return this;
        }

        /// <summary>
        /// The operating system type required for the build.
        /// </summary>
        public AzureAcrBuildTask Os(string os = null)
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
        public AzureAcrBuildTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Secret build argument in 'name[=value]' format.
        /// </summary>
        public AzureAcrBuildTask SecretBuildArg(string secretBuildArg = null)
        {
            WithArguments("--secret-build-arg");
            if (!string.IsNullOrEmpty(secretBuildArg))
            {
                 WithArguments(secretBuildArg);
            }

            return this;
        }

        /// <summary>
        /// The timeout in seconds.
        /// </summary>
        public AzureAcrBuildTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }
     }
}
