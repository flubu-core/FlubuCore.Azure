
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrConfigContentTrustUpdateTask : ExternalProcessTaskBase<AzureAcrConfigContentTrustUpdateTask>
     {
        
        /// <summary>
        /// Update content-trust policy for an Azure Container Registry.
        /// </summary>
        public AzureAcrConfigContentTrustUpdateTask(string name = null)
        {
            WithArguments("az acr config content-trust update");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureAcrConfigContentTrustUpdateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether content-trust is enabled or disabled.
        /// </summary>
        public AzureAcrConfigContentTrustUpdateTask Status(string status = null)
        {
            WithArguments("--status");
            if (!string.IsNullOrEmpty(status))
            {
                 WithArguments(status);
            }

            return this;
        }
     }
}
