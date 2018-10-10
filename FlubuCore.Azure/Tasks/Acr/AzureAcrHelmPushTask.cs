
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrHelmPushTask : ExternalProcessTaskBase<AzureAcrHelmPushTask>
     {
        
        /// <summary>
        /// Push a helm chart package to an Azure Container Registry.
        /// </summary>
        public AzureAcrHelmPushTask(string name = null)
        {
            WithArguments("az acr helm push");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Overwrite the existing chart package.
        /// </summary>
        public AzureAcrHelmPushTask Force(string force = null)
        {
            WithArguments("--force");
            if (!string.IsNullOrEmpty(force))
            {
                 WithArguments(force);
            }

            return this;
        }

        /// <summary>
        /// The password used to log into a container registry.
        /// </summary>
        public AzureAcrHelmPushTask Password(string password = null)
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
        public AzureAcrHelmPushTask Username(string username = null)
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
