
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayNamespaceTask : ExternalProcessTaskBase<AzureRelayNamespaceTask>
     {
        
        /// <summary>
        /// Manage Azure Relay Service Namespace.
        /// </summary>
        public AzureRelayNamespaceTask()
        {
            WithArguments("az relay namespace");
        }

        protected override string Description { get; set; }
        
     }
}
