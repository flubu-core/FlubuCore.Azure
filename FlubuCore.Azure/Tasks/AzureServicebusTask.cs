
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureServicebusTask : ExternalProcessTaskBase<AzureServicebusTask>
     {
        
        /// <summary>
        /// Manage Azure Service Bus namespaces, queues, topics, subscriptions, rules and geo-disaster recovery configuration alias.
        /// </summary>
        public AzureServicebusTask()
        {
            WithArguments("az servicebus");
        }

        protected override string Description { get; set; }
        
     }
}
