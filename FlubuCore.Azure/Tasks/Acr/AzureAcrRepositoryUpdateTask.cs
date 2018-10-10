
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrRepositoryUpdateTask : ExternalProcessTaskBase<AzureAcrRepositoryUpdateTask>
     {
        
        /// <summary>
        /// Update the attributes of a repository or image in an Azure Container Registry.
        /// </summary>
        public AzureAcrRepositoryUpdateTask(string name = null)
        {
            WithArguments("az acr repository update");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Indicates whether delete operation is allowed.
        /// </summary>
        public AzureAcrRepositoryUpdateTask DeleteEnabled(string deleteEnabled = null)
        {
            WithArguments("--delete-enabled");
            if (!string.IsNullOrEmpty(deleteEnabled))
            {
                 WithArguments(deleteEnabled);
            }

            return this;
        }

        /// <summary>
        /// The name of the image. May include a tag in the format 'name:tag' or digest in the format 'name@digest'.
        /// </summary>
        public AzureAcrRepositoryUpdateTask Image(string image = null)
        {
            WithArguments("--image");
            if (!string.IsNullOrEmpty(image))
            {
                 WithArguments(image);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether this item shows in list operation results.
        /// </summary>
        public AzureAcrRepositoryUpdateTask ListEnabled(string listEnabled = null)
        {
            WithArguments("--list-enabled");
            if (!string.IsNullOrEmpty(listEnabled))
            {
                 WithArguments(listEnabled);
            }

            return this;
        }

        /// <summary>
        /// The password used to log into a container registry.
        /// </summary>
        public AzureAcrRepositoryUpdateTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether read operation is allowed.
        /// </summary>
        public AzureAcrRepositoryUpdateTask ReadEnabled(string readEnabled = null)
        {
            WithArguments("--read-enabled");
            if (!string.IsNullOrEmpty(readEnabled))
            {
                 WithArguments(readEnabled);
            }

            return this;
        }

        /// <summary>
        /// The name of the repository.
        /// </summary>
        public AzureAcrRepositoryUpdateTask Repository(string repository = null)
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
        public AzureAcrRepositoryUpdateTask ResourceGroup(string resourceGroup = null)
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
        public AzureAcrRepositoryUpdateTask Username(string username = null)
        {
            WithArguments("--username");
            if (!string.IsNullOrEmpty(username))
            {
                 WithArguments(username);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether write or delete operation is allowed.
        /// </summary>
        public AzureAcrRepositoryUpdateTask WriteEnabled(string writeEnabled = null)
        {
            WithArguments("--write-enabled");
            if (!string.IsNullOrEmpty(writeEnabled))
            {
                 WithArguments(writeEnabled);
            }

            return this;
        }
     }
}
