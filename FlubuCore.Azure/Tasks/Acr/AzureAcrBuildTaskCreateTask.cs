
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrBuildTaskCreateTask : ExternalProcessTaskBase<AzureAcrBuildTaskCreateTask>
     {
        
        /// <summary>
        /// Creates a new build definition which can be triggered by git commits or base image updates for an Azure Container Registry.
        /// </summary>
        public AzureAcrBuildTaskCreateTask(string context = null ,  string gitAccessToken = null ,  string image = null ,  string name = null ,  string registry = null)
        {
            WithArguments("az acr build-task create");
WithArguments("--context");
            if (!string.IsNullOrEmpty(context))
            {
                 WithArguments(context);
            }

WithArguments("--git-access-token");
            if (!string.IsNullOrEmpty(gitAccessToken))
            {
                 WithArguments(gitAccessToken);
            }

WithArguments("--image");
            if (!string.IsNullOrEmpty(image))
            {
                 WithArguments(image);
            }

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
        /// The alternative name for build task. Default to the build task name.
        /// </summary>
        public AzureAcrBuildTaskCreateTask Alias(string alias = null)
        {
            WithArguments("--alias");
            if (!string.IsNullOrEmpty(alias))
            {
                 WithArguments(alias);
            }

            return this;
        }

        /// <summary>
        /// The type of the auto trigger for base image dependency updates.
        /// </summary>
        public AzureAcrBuildTaskCreateTask BaseImageTrigger(string baseImageTrigger = null)
        {
            WithArguments("--base-image-trigger");
            if (!string.IsNullOrEmpty(baseImageTrigger))
            {
                 WithArguments(baseImageTrigger);
            }

            return this;
        }

        /// <summary>
        /// The source control branch name.
        /// </summary>
        public AzureAcrBuildTaskCreateTask Branch(string branch = null)
        {
            WithArguments("--branch");
            if (!string.IsNullOrEmpty(branch))
            {
                 WithArguments(branch);
            }

            return this;
        }

        /// <summary>
        /// Build argument in 'name[=value]' format.
        /// </summary>
        public AzureAcrBuildTaskCreateTask BuildArg(string buildArg = null)
        {
            WithArguments("--build-arg");
            if (!string.IsNullOrEmpty(buildArg))
            {
                 WithArguments(buildArg);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether the source control commit trigger is enabled.
        /// </summary>
        public AzureAcrBuildTaskCreateTask CommitTriggerEnabled(string commitTriggerEnabled = null)
        {
            WithArguments("--commit-trigger-enabled");
            if (!string.IsNullOrEmpty(commitTriggerEnabled))
            {
                 WithArguments(commitTriggerEnabled);
            }

            return this;
        }

        /// <summary>
        /// The CPU configuration in terms of number of cores required for the build.
        /// </summary>
        public AzureAcrBuildTaskCreateTask Cpu(string cpu = null)
        {
            WithArguments("--cpu");
            if (!string.IsNullOrEmpty(cpu))
            {
                 WithArguments(cpu);
            }

            return this;
        }

        /// <summary>
        /// The relative path of the the docker file to the source code root folder.
        /// </summary>
        public AzureAcrBuildTaskCreateTask File(string file = null)
        {
            WithArguments("--file");
            if (!string.IsNullOrEmpty(file))
            {
                 WithArguments(file);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether the image cache is enabled.
        /// </summary>
        public AzureAcrBuildTaskCreateTask NoCache(string noCache = null)
        {
            WithArguments("--no-cache");
            if (!string.IsNullOrEmpty(noCache))
            {
                 WithArguments(noCache);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether the image built should be pushed to the registry.
        /// </summary>
        public AzureAcrBuildTaskCreateTask NoPush(string noPush = null)
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
        public AzureAcrBuildTaskCreateTask Os(string os = null)
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
        public AzureAcrBuildTaskCreateTask ResourceGroup(string resourceGroup = null)
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
        public AzureAcrBuildTaskCreateTask SecretBuildArg(string secretBuildArg = null)
        {
            WithArguments("--secret-build-arg");
            if (!string.IsNullOrEmpty(secretBuildArg))
            {
                 WithArguments(secretBuildArg);
            }

            return this;
        }

        /// <summary>
        /// The current status of build task.
        /// </summary>
        public AzureAcrBuildTaskCreateTask Status(string status = null)
        {
            WithArguments("--status");
            if (!string.IsNullOrEmpty(status))
            {
                 WithArguments(status);
            }

            return this;
        }

        /// <summary>
        /// The timeout in seconds.
        /// </summary>
        public AzureAcrBuildTaskCreateTask Timeout(string timeout = null)
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
