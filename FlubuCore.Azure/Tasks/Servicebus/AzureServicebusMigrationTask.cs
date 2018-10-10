
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusMigrationTask : ExternalProcessTaskBase<AzureServicebusMigrationTask>
     {
        
        /// <summary>
        /// Manage Azure Service Bus Migration of Standard to Premium.
        /// </summary>
        public AzureServicebusMigrationTask()
        {
            WithArguments("az servicebus migration");
        }

        protected override string Description { get; set; }
        
     }
}
