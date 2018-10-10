
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Group
{
     public partial class AzureGroupDeploymentOperationTask : ExternalProcessTaskBase<AzureGroupDeploymentOperationTask>
     {
        
        /// <summary>
        /// Manage deployment operations.
        /// </summary>
        public AzureGroupDeploymentOperationTask()
        {
            WithArguments("az group deployment operation");
        }

        protected override string Description { get; set; }
        
     }
}
