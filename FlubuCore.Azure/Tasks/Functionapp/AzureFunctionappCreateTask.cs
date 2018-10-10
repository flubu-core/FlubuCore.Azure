
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappCreateTask : ExternalProcessTaskBase<AzureFunctionappCreateTask>
     {
        
        /// <summary>
        /// Create a function app.
        /// </summary>
        public AzureFunctionappCreateTask(string name = null ,  string resourceGroup = null ,  string storageAccount = null)
        {
            WithArguments("az functionapp create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--storage-account");
            if (!string.IsNullOrEmpty(storageAccount))
            {
                 WithArguments(storageAccount);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Geographic location where Function App will be hosted. Use 'functionapp list-consumption-locations' to view available locations.
        /// </summary>
        public AzureFunctionappCreateTask ConsumptionPlanLocation(string consumptionPlanLocation = null)
        {
            WithArguments("--consumption-plan-location");
            if (!string.IsNullOrEmpty(consumptionPlanLocation))
            {
                 WithArguments(consumptionPlanLocation);
            }

            return this;
        }

        /// <summary>
        /// Linux only. Container image name from Docker Hub, e.g. publisher/image-name:tag.
        /// </summary>
        public AzureFunctionappCreateTask DeploymentContainerImageName(string deploymentContainerImageName = null)
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
        public AzureFunctionappCreateTask DeploymentLocalGit(string deploymentLocalGit = null)
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
        public AzureFunctionappCreateTask DeploymentSourceBranch(string deploymentSourceBranch = null)
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
        public AzureFunctionappCreateTask DeploymentSourceUrl(string deploymentSourceUrl = null)
        {
            WithArguments("--deployment-source-url");
            if (!string.IsNullOrEmpty(deploymentSourceUrl))
            {
                 WithArguments(deploymentSourceUrl);
            }

            return this;
        }

        /// <summary>
        /// Name or resource id of the function app service plan. Use 'appservice plan create' to get one.
        /// </summary>
        public AzureFunctionappCreateTask Plan(string plan = null)
        {
            WithArguments("--plan");
            if (!string.IsNullOrEmpty(plan))
            {
                 WithArguments(plan);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureFunctionappCreateTask Tags(string tags = null)
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
