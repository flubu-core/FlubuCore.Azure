
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeploymentSlotTask : ExternalProcessTaskBase<AzureWebappDeploymentSlotTask>
     {
        
        /// <summary>
        /// Manage web app deployment slots.
        /// </summary>
        public AzureWebappDeploymentSlotTask()
        {
            WithArguments("az webapp deployment slot");
        }

        protected override string Description { get; set; }
        
     }
}
