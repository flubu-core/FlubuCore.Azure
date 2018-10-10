
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsNamespaceExistsTask : ExternalProcessTaskBase<AzureEventhubsNamespaceExistsTask>
     {
        
        /// <summary>
        /// Check for the availability of the given name for the Namespace.
        /// </summary>
        public AzureEventhubsNamespaceExistsTask(string name = null)
        {
            WithArguments("az eventhubs namespace exists");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
