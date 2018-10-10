
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayNamespaceDeleteTask : ExternalProcessTaskBase<AzureRelayNamespaceDeleteTask>
     {
        
        /// <summary>
        /// Deletes the Relay Service Namespace.
        /// </summary>
        public AzureRelayNamespaceDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az relay namespace delete");
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
