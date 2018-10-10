
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrHelmDeleteTask : ExternalProcessTaskBase<AzureAcrHelmDeleteTask>
     {
        
        /// <summary>
        /// Delete a helm chart version in an Azure Container Registry.
        /// </summary>
        public AzureAcrHelmDeleteTask(string name = null)
        {
            WithArguments("az acr helm delete");
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
        public AzureAcrHelmDeleteTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// Only delete the provenance file.
        /// </summary>
        public AzureAcrHelmDeleteTask Prov(string prov = null)
        {
            WithArguments("--prov");
            if (!string.IsNullOrEmpty(prov))
            {
                 WithArguments(prov);
            }

            return this;
        }

        /// <summary>
        /// The username used to log into a container registry.
        /// </summary>
        public AzureAcrHelmDeleteTask Username(string username = null)
        {
            WithArguments("--username");
            if (!string.IsNullOrEmpty(username))
            {
                 WithArguments(username);
            }

            return this;
        }

        /// <summary>
        /// The helm chart version.
        /// </summary>
        public AzureAcrHelmDeleteTask Version(string version = null)
        {
            WithArguments("--version");
            if (!string.IsNullOrEmpty(version))
            {
                 WithArguments(version);
            }

            return this;
        }

        /// <summary>
        /// Do not prompt for confirmation.
        /// </summary>
        public AzureAcrHelmDeleteTask Yes(string yes = null)
        {
            WithArguments("--yes");
            if (!string.IsNullOrEmpty(yes))
            {
                 WithArguments(yes);
            }

            return this;
        }
     }
}
