
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeploymentSlotCreateTask : ExternalProcessTaskBase<AzureWebappDeploymentSlotCreateTask>
     {
        
        /// <summary>
        /// Create a deployment slot.
        /// </summary>
        public AzureWebappDeploymentSlotCreateTask(string name = null ,  string resourceGroup = null ,  string slot = null)
        {
            WithArguments("az webapp deployment slot create");
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
        /// Source slot to clone configurations from. Use webapp's name to refer to the production slot.
        /// </summary>
        public AzureWebappDeploymentSlotCreateTask ConfigurationSource(string configurationSource = null)
        {
            WithArguments("--configuration-source");
            if (!string.IsNullOrEmpty(configurationSource))
            {
                 WithArguments(configurationSource);
            }

            return this;
        }
     }
}
