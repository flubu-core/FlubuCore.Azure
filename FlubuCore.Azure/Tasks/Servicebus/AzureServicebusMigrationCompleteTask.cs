
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusMigrationCompleteTask : ExternalProcessTaskBase<AzureServicebusMigrationCompleteTask>
     {
        
        /// <summary>
        /// Completes the Service Bus Migration of Standard to Premium namespace.
        /// </summary>
        public AzureServicebusMigrationCompleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az servicebus migration complete");
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
