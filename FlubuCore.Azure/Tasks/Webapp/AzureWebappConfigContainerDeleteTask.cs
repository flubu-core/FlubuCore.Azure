
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigContainerDeleteTask : ExternalProcessTaskBase<AzureWebappConfigContainerDeleteTask>
     {
        
        /// <summary>
        /// Delete a web app container's settings.
        /// </summary>
        public AzureWebappConfigContainerDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp config container delete");
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
        
        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappConfigContainerDeleteTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }
     }
}
