
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Account
{
     public partial class AzureAccountGetAccessTokenTask : ExternalProcessTaskBase<AzureAccountGetAccessTokenTask>
     {
        
        /// <summary>
        /// Get a token for utilities to access Azure.
        /// </summary>
        public AzureAccountGetAccessTokenTask()
        {
            WithArguments("az account get-access-token");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Azure resource endpoints. Default to Azure Resource Manager Use 'az cloud show' command for other Azure resources.
        /// </summary>
        public AzureAccountGetAccessTokenTask Resource(string resource = null)
        {
            WithArguments("--resource");
            if (!string.IsNullOrEmpty(resource))
            {
                 WithArguments(resource);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of subscription.
        /// </summary>
        public AzureAccountGetAccessTokenTask Subscription(string subscription = null)
        {
            WithArguments("--subscription");
            if (!string.IsNullOrEmpty(subscription))
            {
                 WithArguments(subscription);
            }

            return this;
        }
     }
}
