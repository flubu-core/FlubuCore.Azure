
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrHelmRepoAddTask : ExternalProcessTaskBase<AzureAcrHelmRepoAddTask>
     {
        
        /// <summary>
        /// Add a helm chart repository from an Azure Container Registry through the Helm CLI.
        /// </summary>
        public AzureAcrHelmRepoAddTask(string name = null)
        {
            WithArguments("az acr helm repo add");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The password used to log into a container registry.
        /// </summary>
        public AzureAcrHelmRepoAddTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// The username used to log into a container registry.
        /// </summary>
        public AzureAcrHelmRepoAddTask Username(string username = null)
        {
            WithArguments("--username");
            if (!string.IsNullOrEmpty(username))
            {
                 WithArguments(username);
            }

            return this;
        }
     }
}
