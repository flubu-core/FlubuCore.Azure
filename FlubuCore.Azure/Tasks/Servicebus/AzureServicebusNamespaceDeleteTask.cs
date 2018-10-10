
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusNamespaceDeleteTask : ExternalProcessTaskBase<AzureServicebusNamespaceDeleteTask>
     {
        
        /// <summary>
        /// Deletes the Service Bus Namespace.
        /// </summary>
        public AzureServicebusNamespaceDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az servicebus namespace delete");
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
        
     }
}
