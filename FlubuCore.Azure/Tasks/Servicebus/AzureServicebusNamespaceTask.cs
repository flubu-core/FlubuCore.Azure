
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusNamespaceTask : ExternalProcessTaskBase<AzureServicebusNamespaceTask>
     {
        
        /// <summary>
        /// Manage Azure Service Bus Namespace.
        /// </summary>
        public AzureServicebusNamespaceTask()
        {
            WithArguments("az servicebus namespace");
        }

        protected override string Description { get; set; }
        
     }
}
