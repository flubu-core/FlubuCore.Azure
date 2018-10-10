
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventgrid
{
     public partial class AzureEventgridEventSubscriptionTask : ExternalProcessTaskBase<AzureEventgridEventSubscriptionTask>
     {
        
        /// <summary>
        /// Manage event subscriptions for an Event Grid topic or for an Azure resource.
        /// </summary>
        public AzureEventgridEventSubscriptionTask()
        {
            WithArguments("az eventgrid event-subscription");
        }

        protected override string Description { get; set; }
        
     }
}
