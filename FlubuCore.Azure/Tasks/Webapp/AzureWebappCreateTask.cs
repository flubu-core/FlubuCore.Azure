
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappCreateTask : ExternalProcessTaskBase<AzureWebappCreateTask>
     {
        
        /// <summary>
        /// Create a web app.
        /// </summary>
        public AzureWebappCreateTask(string name = null ,  string plan = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--plan");
            if (!string.IsNullOrEmpty(plan))
            {
                 WithArguments(plan);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Linux only. Container image name from Docker Hub, e.g. publisher/image-name:tag.
        /// </summary>
        public AzureWebappCreateTask DeploymentContainerImageName(string deploymentContainerImageName = null)
        {
            WithArguments("--deployment-container-image-name");
            if (!string.IsNullOrEmpty(deploymentContainerImageName))
            {
                 WithArguments(deploymentContainerImageName);
            }

            return this;
        }

        /// <summary>
        /// Enable local git.
        /// </summary>
        public AzureWebappCreateTask DeploymentLocalGit(string deploymentLocalGit = null)
        {
            WithArguments("--deployment-local-git");
            if (!string.IsNullOrEmpty(deploymentLocalGit))
            {
                 WithArguments(deploymentLocalGit);
            }

            return this;
        }

        /// <summary>
        /// The branch to deploy.
        /// </summary>
        public AzureWebappCreateTask DeploymentSourceBranch(string deploymentSourceBranch = null)
        {
            WithArguments("--deployment-source-branch");
            if (!string.IsNullOrEmpty(deploymentSourceBranch))
            {
                 WithArguments(deploymentSourceBranch);
            }

            return this;
        }

        /// <summary>
        /// Git repository URL to link with manual integration.
        /// </summary>
        public AzureWebappCreateTask DeploymentSourceUrl(string deploymentSourceUrl = null)
        {
            WithArguments("--deployment-source-url");
            if (!string.IsNullOrEmpty(deploymentSourceUrl))
            {
                 WithArguments(deploymentSourceUrl);
            }

            return this;
        }

        /// <summary>
        /// Linux only. Config file for multicontainer apps. (local or remote).
        /// </summary>
        public AzureWebappCreateTask MulticontainerConfigFile(string multicontainerConfigFile = null)
        {
            WithArguments("--multicontainer-config-file");
            if (!string.IsNullOrEmpty(multicontainerConfigFile))
            {
                 WithArguments(multicontainerConfigFile);
            }

            return this;
        }

        /// <summary>
        /// Linux only.
        /// </summary>
        public AzureWebappCreateTask MulticontainerConfigType(string multicontainerConfigType = null)
        {
            WithArguments("--multicontainer-config-type");
            if (!string.IsNullOrEmpty(multicontainerConfigType))
            {
                 WithArguments(multicontainerConfigType);
            }

            return this;
        }

        /// <summary>
        /// Canonicalized web runtime in the format of Framework|Version, e.g. "PHP|5.6". Use 'az webapp list-runtimes' for available list.
        /// </summary>
        public AzureWebappCreateTask Runtime(string runtime = null)
        {
            WithArguments("--runtime");
            if (!string.IsNullOrEmpty(runtime))
            {
                 WithArguments(runtime);
            }

            return this;
        }

        /// <summary>
        /// Linux only. The web's startup file.
        /// </summary>
        public AzureWebappCreateTask StartupFile(string startupFile = null)
        {
            WithArguments("--startup-file");
            if (!string.IsNullOrEmpty(startupFile))
            {
                 WithArguments(startupFile);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureWebappCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }
     }
}
