
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusNamespaceExistsTask : ExternalProcessTaskBase<AzureServicebusNamespaceExistsTask>
     {
        
        /// <summary>
        /// Check for the availability of the given name for the Namespace.
        /// </summary>
        public AzureServicebusNamespaceExistsTask(string name = null)
        {
            WithArguments("az servicebus namespace exists");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
