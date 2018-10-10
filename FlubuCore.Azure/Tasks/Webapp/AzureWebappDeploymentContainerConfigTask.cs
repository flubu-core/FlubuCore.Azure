
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeploymentContainerConfigTask : ExternalProcessTaskBase<AzureWebappDeploymentContainerConfigTask>
     {
        
        /// <summary>
        /// Configure continuous deployment via containers.
        /// </summary>
        public AzureWebappDeploymentContainerConfigTask(string enableCd = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp deployment container config");
WithArguments("--enable-cd");
            if (!string.IsNullOrEmpty(enableCd))
            {
                 WithArguments(enableCd);
            }

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
        public AzureWebappDeploymentContainerConfigTask Slot(string slot = null)
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
