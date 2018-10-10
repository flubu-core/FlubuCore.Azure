
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mesh
{
     public partial class AzureMeshDeploymentTask : ExternalProcessTaskBase<AzureMeshDeploymentTask>
     {
        
        /// <summary>
        /// Manage Service Fabric Mesh deployments.
        /// </summary>
        public AzureMeshDeploymentTask()
        {
            WithArguments("az mesh deployment");
        }

        protected override string Description { get; set; }
        
     }
}
