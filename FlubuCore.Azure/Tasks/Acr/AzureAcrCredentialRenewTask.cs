
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrCredentialRenewTask : ExternalProcessTaskBase<AzureAcrCredentialRenewTask>
     {
        
        /// <summary>
        /// Regenerate login credentials for an Azure Container Registry.
        /// </summary>
        public AzureAcrCredentialRenewTask(string name = null ,  string passwordName = null)
        {
            WithArguments("az acr credential renew");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--password-name");
            if (!string.IsNullOrEmpty(passwordName))
            {
                 WithArguments(passwordName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureAcrCredentialRenewTask ResourceGroup(string resourceGroup = null)
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
