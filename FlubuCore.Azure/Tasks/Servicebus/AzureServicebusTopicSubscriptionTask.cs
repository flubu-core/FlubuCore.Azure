
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusTopicSubscriptionTask : ExternalProcessTaskBase<AzureServicebusTopicSubscriptionTask>
     {
        
        /// <summary>
        /// Manage Azure Service Bus Subscription.
        /// </summary>
        public AzureServicebusTopicSubscriptionTask()
        {
            WithArguments("az servicebus topic subscription");
        }

        protected override string Description { get; set; }
        
     }
}
