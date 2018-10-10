
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeploymentSlotSwapTask : ExternalProcessTaskBase<AzureWebappDeploymentSlotSwapTask>
     {
        
        /// <summary>
        /// Change deployment slots for a web app.
        /// </summary>
        public AzureWebappDeploymentSlotSwapTask(string name = null ,  string resourceGroup = null ,  string slot = null)
        {
            WithArguments("az webapp deployment slot swap");
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
        /// Swap types. use 'preview' to apply target slot's settings on the source slot first; use 'swap' to complete it; use 'reset' to reset the swap.
        /// </summary>
        public AzureWebappDeploymentSlotSwapTask Action(string action = null)
        {
            WithArguments("--action");
            if (!string.IsNullOrEmpty(action))
            {
                 WithArguments(action);
            }

            return this;
        }

        /// <summary>
        /// Target slot to swap, default to 'production'.
        /// </summary>
        public AzureWebappDeploymentSlotSwapTask TargetSlot(string targetSlot = null)
        {
            WithArguments("--target-slot");
            if (!string.IsNullOrEmpty(targetSlot))
            {
                 WithArguments(targetSlot);
            }

            return this;
        }
     }
}
