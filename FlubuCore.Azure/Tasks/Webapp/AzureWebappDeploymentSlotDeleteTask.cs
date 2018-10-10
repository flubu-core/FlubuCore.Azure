
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeploymentSlotDeleteTask : ExternalProcessTaskBase<AzureWebappDeploymentSlotDeleteTask>
     {
        
        /// <summary>
        /// Delete a deployment slot.
        /// </summary>
        public AzureWebappDeploymentSlotDeleteTask(string name = null ,  string resourceGroup = null ,  string slot = null)
        {
            WithArguments("az webapp deployment slot delete");
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

WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

        }

        protected override string Description { get; set; }
        
     }
}
