
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotEdgeDeploymentTask : ExternalProcessTaskBase<AzureIotEdgeDeploymentTask>
     {
        
        /// <summary>
        /// Manage IoT Edge deployments at scale.
        /// </summary>
        public AzureIotEdgeDeploymentTask()
        {
            WithArguments("az iot edge deployment");
        }

        protected override string Description { get; set; }
        
     }
}
