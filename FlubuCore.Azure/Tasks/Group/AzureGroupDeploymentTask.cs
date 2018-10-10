
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Group
{
     public partial class AzureGroupDeploymentTask : ExternalProcessTaskBase<AzureGroupDeploymentTask>
     {
        
        /// <summary>
        /// Manage Azure Resource Manager deployments.
        /// </summary>
        public AzureGroupDeploymentTask()
        {
            WithArguments("az group deployment");
        }

        protected override string Description { get; set; }
        
     }
}
