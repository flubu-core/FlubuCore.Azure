
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrImportTask : ExternalProcessTaskBase<AzureAcrImportTask>
     {
        
        /// <summary>
        /// Imports an image to an Azure Container Registry from another Container Registry. Import removes the need to docker pull, docker tag, docker push.
        /// </summary>
        public AzureAcrImportTask(string name = null ,  string source = null)
        {
            WithArguments("az acr import");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--source");
            if (!string.IsNullOrEmpty(source))
            {
                 WithArguments(source);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Overwrite the existing tag of the image to be imported.
        /// </summary>
        public AzureAcrImportTask Force(string force = null)
        {
            WithArguments("--force");
            if (!string.IsNullOrEmpty(force))
            {
                 WithArguments(force);
            }

            return this;
        }

        /// <summary>
        /// The name of the image. May include a tag in the format 'name:tag'.
        /// </summary>
        public AzureAcrImportTask Image(string image = null)
        {
            WithArguments("--image");
            if (!string.IsNullOrEmpty(image))
            {
                 WithArguments(image);
            }

            return this;
        }

        /// <summary>
        /// The source container registry can be name, login server or resource ID of the source registry.
        /// </summary>
        public AzureAcrImportTask Registry(string registry = null)
        {
            WithArguments("--registry");
            if (!string.IsNullOrEmpty(registry))
            {
                 WithArguments(registry);
            }

            return this;
        }

        /// <summary>
        /// The repository name to do a manifest-only copy for images.
        /// </summary>
        public AzureAcrImportTask Repository(string repository = null)
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
        public AzureAcrImportTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }
     }
}
