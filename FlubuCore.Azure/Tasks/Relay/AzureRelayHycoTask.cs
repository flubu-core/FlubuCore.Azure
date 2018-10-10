
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayHycoTask : ExternalProcessTaskBase<AzureRelayHycoTask>
     {
        
        /// <summary>
        /// Manage Azure Relay Service Hybrid Connection and Authorization Rule.
        /// </summary>
        public AzureRelayHycoTask()
        {
            WithArguments("az relay hyco");
        }

        protected override string Description { get; set; }
        
     }
}
