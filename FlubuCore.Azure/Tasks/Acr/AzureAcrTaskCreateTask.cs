
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrTaskCreateTask : ExternalProcessTaskBase<AzureAcrTaskCreateTask>
     {
        
        /// <summary>
        /// Creates a series of steps for building, testing and OS & Framework patching containers. Tasks support triggers from git commits and base image updates.
        /// </summary>
        public AzureAcrTaskCreateTask(string context = null ,  string file = null ,  string name = null ,  string registry = null)
        {
            WithArguments("az acr task create");
WithArguments("--context");
            if (!string.IsNullOrEmpty(context))
            {
                 WithArguments(context);
            }

WithArguments("--file");
            if (!string.IsNullOrEmpty(file))
            {
                 WithArguments(file);
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
        /// Build argument in 'name[=value]' format.
        /// </summary>
        public AzureAcrTaskCreateTask Arg(string arg = null)
        {
            WithArguments("--arg");
            if (!string.IsNullOrEmpty(arg))
            {
                 WithArguments(arg);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether the base image trigger is enabled.
        /// </summary>
        public AzureAcrTaskCreateTask BaseImageTriggerEnabled(string baseImageTriggerEnabled = null)
        {
            WithArguments("--base-image-trigger-enabled");
            if (!string.IsNullOrEmpty(baseImageTriggerEnabled))
            {
                 WithArguments(baseImageTriggerEnabled);
            }

            return this;
        }

        /// <summary>
        /// The name of the base image trigger.
        /// </summary>
        public AzureAcrTaskCreateTask BaseImageTriggerName(string baseImageTriggerName = null)
        {
            WithArguments("--base-image-trigger-name");
            if (!string.IsNullOrEmpty(baseImageTriggerName))
            {
                 WithArguments(baseImageTriggerName);
            }

            return this;
        }

        /// <summary>
        /// The type of the auto trigger for base image dependency updates.
        /// </summary>
        public AzureAcrTaskCreateTask BaseImageTriggerType(string baseImageTriggerType = null)
        {
            WithArguments("--base-image-trigger-type");
            if (!string.IsNullOrEmpty(baseImageTriggerType))
            {
                 WithArguments(baseImageTriggerType);
            }

            return this;
        }

        /// <summary>
        /// The source control branch name.
        /// </summary>
        public AzureAcrTaskCreateTask Branch(string branch = null)
        {
            WithArguments("--branch");
            if (!string.IsNullOrEmpty(branch))
            {
                 WithArguments(branch);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether the source control commit trigger is enabled.
        /// </summary>
        public AzureAcrTaskCreateTask CommitTriggerEnabled(string commitTriggerEnabled = null)
        {
            WithArguments("--commit-trigger-enabled");
            if (!string.IsNullOrEmpty(commitTriggerEnabled))
            {
                 WithArguments(commitTriggerEnabled);
            }

            return this;
        }

        /// <summary>
        /// The CPU configuration in terms of number of cores required for the run.
        /// </summary>
        public AzureAcrTaskCreateTask Cpu(string cpu = null)
        {
            WithArguments("--cpu");
            if (!string.IsNullOrEmpty(cpu))
            {
                 WithArguments(cpu);
            }

            return this;
        }

        /// <summary>
        /// The access token used to access the source control provider.
        /// </summary>
        public AzureAcrTaskCreateTask GitAccessToken(string gitAccessToken = null)
        {
            WithArguments("--git-access-token");
            if (!string.IsNullOrEmpty(gitAccessToken))
            {
                 WithArguments(gitAccessToken);
            }

            return this;
        }

        /// <summary>
        /// The name of the image. May include a tag in the format 'name:tag'.
        /// </summary>
        public AzureAcrTaskCreateTask Image(string image = null)
        {
            WithArguments("--image");
            if (!string.IsNullOrEmpty(image))
            {
                 WithArguments(image);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether the image cache is enabled.
        /// </summary>
        public AzureAcrTaskCreateTask NoCache(string noCache = null)
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
        public AzureAcrTaskCreateTask NoPush(string noPush = null)
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
        public AzureAcrTaskCreateTask Os(string os = null)
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
        public AzureAcrTaskCreateTask ResourceGroup(string resourceGroup = null)
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
        public AzureAcrTaskCreateTask SecretArg(string secretArg = null)
        {
            WithArguments("--secret-arg");
            if (!string.IsNullOrEmpty(secretArg))
            {
                 WithArguments(secretArg);
            }

            return this;
        }

        /// <summary>
        /// Task value in 'name[=value]' format.
        /// </summary>
        public AzureAcrTaskCreateTask Set(string set = null)
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
        public AzureAcrTaskCreateTask SetSecret(string setSecret = null)
        {
            WithArguments("--set-secret");
            if (!string.IsNullOrEmpty(setSecret))
            {
                 WithArguments(setSecret);
            }

            return this;
        }

        /// <summary>
        /// The name of the source trigger.
        /// </summary>
        public AzureAcrTaskCreateTask SourceTriggerName(string sourceTriggerName = null)
        {
            WithArguments("--source-trigger-name");
            if (!string.IsNullOrEmpty(sourceTriggerName))
            {
                 WithArguments(sourceTriggerName);
            }

            return this;
        }

        /// <summary>
        /// The current status of task.
        /// </summary>
        public AzureAcrTaskCreateTask Status(string status = null)
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
        public AzureAcrTaskCreateTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// The task values/parameters file path relative to the source context.
        /// </summary>
        public AzureAcrTaskCreateTask Values(string values = null)
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
