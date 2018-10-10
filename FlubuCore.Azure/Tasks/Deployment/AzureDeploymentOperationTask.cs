
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Deployment
{
     public partial class AzureDeploymentOperationTask : ExternalProcessTaskBase<AzureDeploymentOperationTask>
     {
        
        /// <summary>
        /// Manage deployment operations.
        /// </summary>
        public AzureDeploymentOperationTask()
        {
            WithArguments("az deployment operation");
        }

        protected override string Description { get; set; }
        
     }
}
