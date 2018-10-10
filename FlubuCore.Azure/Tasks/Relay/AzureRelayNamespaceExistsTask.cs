
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayNamespaceExistsTask : ExternalProcessTaskBase<AzureRelayNamespaceExistsTask>
     {
        
        /// <summary>
        /// Check for the availability of the given name for the Namespace.
        /// </summary>
        public AzureRelayNamespaceExistsTask(string name = null)
        {
            WithArguments("az relay namespace exists");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
