
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeploymentSourceConfigZipTask : ExternalProcessTaskBase<AzureWebappDeploymentSourceConfigZipTask>
     {
        
        /// <summary>
        /// Perform deployment using the kudu zip push deployment for a webapp.
        /// </summary>
        public AzureWebappDeploymentSourceConfigZipTask(string name = null ,  string resourceGroup = null ,  string src = null)
        {
            WithArguments("az webapp deployment source config-zip");
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

WithArguments("--src");
            if (!string.IsNullOrEmpty(src))
            {
                 WithArguments(src);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappDeploymentSourceConfigZipTask Slot(string slot = null)
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
