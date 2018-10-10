
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureRelayTask : ExternalProcessTaskBase<AzureRelayTask>
     {
        
        /// <summary>
        /// Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.
        /// </summary>
        public AzureRelayTask()
        {
            WithArguments("az relay");
        }

        protected override string Description { get; set; }
        
     }
}
