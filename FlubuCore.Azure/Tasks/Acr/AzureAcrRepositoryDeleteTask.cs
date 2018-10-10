
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrRepositoryDeleteTask : ExternalProcessTaskBase<AzureAcrRepositoryDeleteTask>
     {
        
        /// <summary>
        /// Delete a repository or image in an Azure Container Registry.
        /// </summary>
        public AzureAcrRepositoryDeleteTask(string name = null)
        {
            WithArguments("az acr repository delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.
        /// </summary>
        public AzureAcrRepositoryDeleteTask Image(string image = null)
        {
            WithArguments("--image");
            if (!string.IsNullOrEmpty(image))
            {
                 WithArguments(image);
            }

            return this;
        }

        /// <summary>
        /// The password used to log into a container registry.
        /// </summary>
        public AzureAcrRepositoryDeleteTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// The name of the repository.
        /// </summary>
        public AzureAcrRepositoryDeleteTask Repository(string repository = null)
        {
            WithArguments("--repository");
            if (!string.IsNullOrEmpty(repository))
            {
                 WithArguments(repository);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureAcrRepositoryDeleteTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// The username used to log into a container registry.
        /// </summary>
        public AzureAcrRepositoryDeleteTask Username(string username = null)
        {
            WithArguments("--username");
            if (!string.IsNullOrEmpty(username))
            {
                 WithArguments(username);
            }

            return this;
        }

        /// <summary>
        /// Do not prompt for confirmation.
        /// </summary>
        public AzureAcrRepositoryDeleteTask Yes(string yes = null)
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
