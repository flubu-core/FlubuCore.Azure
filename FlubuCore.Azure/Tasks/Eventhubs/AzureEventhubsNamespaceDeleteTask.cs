
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsNamespaceDeleteTask : ExternalProcessTaskBase<AzureEventhubsNamespaceDeleteTask>
     {
        
        /// <summary>
        /// Deletes the Namespaces.
        /// </summary>
        public AzureEventhubsNamespaceDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az eventhubs namespace delete");
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
