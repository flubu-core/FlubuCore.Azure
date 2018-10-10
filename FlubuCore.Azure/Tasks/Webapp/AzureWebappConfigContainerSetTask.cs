
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigContainerSetTask : ExternalProcessTaskBase<AzureWebappConfigContainerSetTask>
     {
        
        /// <summary>
        /// Set a web app container's settings.
        /// </summary>
        public AzureWebappConfigContainerSetTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp config container set");
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

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The container custom image name and optionally the tag name.
        /// </summary>
        public AzureWebappConfigContainerSetTask DockerCustomImageName(string dockerCustomImageName = null)
        {
            WithArguments("--docker-custom-image-name");
            if (!string.IsNullOrEmpty(dockerCustomImageName))
            {
                 WithArguments(dockerCustomImageName);
            }

            return this;
        }

        /// <summary>
        /// The container registry server password.
        /// </summary>
        public AzureWebappConfigContainerSetTask DockerRegistryServerPassword(string dockerRegistryServerPassword = null)
        {
            WithArguments("--docker-registry-server-password");
            if (!string.IsNullOrEmpty(dockerRegistryServerPassword))
            {
                 WithArguments(dockerRegistryServerPassword);
            }

            return this;
        }

        /// <summary>
        /// The container registry server url.
        /// </summary>
        public AzureWebappConfigContainerSetTask DockerRegistryServerUrl(string dockerRegistryServerUrl = null)
        {
            WithArguments("--docker-registry-server-url");
            if (!string.IsNullOrEmpty(dockerRegistryServerUrl))
            {
                 WithArguments(dockerRegistryServerUrl);
            }

            return this;
        }

        /// <summary>
        /// The container registry server username.
        /// </summary>
        public AzureWebappConfigContainerSetTask DockerRegistryServerUser(string dockerRegistryServerUser = null)
        {
            WithArguments("--docker-registry-server-user");
            if (!string.IsNullOrEmpty(dockerRegistryServerUser))
            {
                 WithArguments(dockerRegistryServerUser);
            }

            return this;
        }

        /// <summary>
        /// Enables platform storage (custom container only).
        /// </summary>
        public AzureWebappConfigContainerSetTask EnableAppServiceStorage(string enableAppServiceStorage = null)
        {
            WithArguments("--enable-app-service-storage");
            if (!string.IsNullOrEmpty(enableAppServiceStorage))
            {
                 WithArguments(enableAppServiceStorage);
            }

            return this;
        }

        /// <summary>
        /// Config file for multicontainer apps.
        /// </summary>
        public AzureWebappConfigContainerSetTask MulticontainerConfigFile(string multicontainerConfigFile = null)
        {
            WithArguments("--multicontainer-config-file");
            if (!string.IsNullOrEmpty(multicontainerConfigFile))
            {
                 WithArguments(multicontainerConfigFile);
            }

            return this;
        }

        /// <summary>
        /// Config type.
        /// </summary>
        public AzureWebappConfigContainerSetTask MulticontainerConfigType(string multicontainerConfigType = null)
        {
            WithArguments("--multicontainer-config-type");
            if (!string.IsNullOrEmpty(multicontainerConfigType))
            {
                 WithArguments(multicontainerConfigType);
            }

            return this;
        }

        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappConfigContainerSetTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }
     }
}
