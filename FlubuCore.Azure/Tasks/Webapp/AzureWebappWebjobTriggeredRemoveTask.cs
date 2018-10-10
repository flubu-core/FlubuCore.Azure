
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappWebjobTriggeredRemoveTask : ExternalProcessTaskBase<AzureWebappWebjobTriggeredRemoveTask>
     {
        
        /// <summary>
        /// Delete a specific triggered webjob hosted on a webapp.
        /// </summary>
        public AzureWebappWebjobTriggeredRemoveTask(string name = null ,  string resourceGroup = null ,  string webjobName = null)
        {
            WithArguments("az webapp webjob triggered remove");
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

WithArguments("--webjob-name");
            if (!string.IsNullOrEmpty(webjobName))
            {
                 WithArguments(webjobName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappWebjobTriggeredRemoveTask Slot(string slot = null)
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
