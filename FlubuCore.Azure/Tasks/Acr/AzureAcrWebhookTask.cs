
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrWebhookTask : ExternalProcessTaskBase<AzureAcrWebhookTask>
     {
        
        /// <summary>
        /// Manage webhooks for Azure Container Registries.
        /// </summary>
        public AzureAcrWebhookTask()
        {
            WithArguments("az acr webhook");
        }

        protected override string Description { get; set; }
        
     }
}
