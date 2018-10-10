
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeploymentSlotAutoSwapTask : ExternalProcessTaskBase<AzureWebappDeploymentSlotAutoSwapTask>
     {
        
        /// <summary>
        /// Configure deployment slot auto swap.
        /// </summary>
        public AzureWebappDeploymentSlotAutoSwapTask(string name = null ,  string resourceGroup = null ,  string slot = null)
        {
            WithArguments("az webapp deployment slot auto-swap");
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
        
        /// <summary>
        /// Target slot to auto swap.
        /// </summary>
        public AzureWebappDeploymentSlotAutoSwapTask AutoSwapSlot(string autoSwapSlot = null)
        {
            WithArguments("--auto-swap-slot");
            if (!string.IsNullOrEmpty(autoSwapSlot))
            {
                 WithArguments(autoSwapSlot);
            }

            return this;
        }

        /// <summary>
        /// Disable auto swap.
        /// </summary>
        public AzureWebappDeploymentSlotAutoSwapTask Disable(string disable = null)
        {
            WithArguments("--disable");
            if (!string.IsNullOrEmpty(disable))
            {
                 WithArguments(disable);
            }

            return this;
        }
     }
}
