
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrLoginTask : ExternalProcessTaskBase<AzureAcrLoginTask>
     {
        
        /// <summary>
        /// Log in to an Azure Container Registry through the Docker CLI.
        /// </summary>
        public AzureAcrLoginTask(string name = null)
        {
            WithArguments("az acr login");
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
        public AzureAcrLoginTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureAcrLoginTask ResourceGroup(string resourceGroup = null)
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
        public AzureAcrLoginTask Username(string username = null)
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
