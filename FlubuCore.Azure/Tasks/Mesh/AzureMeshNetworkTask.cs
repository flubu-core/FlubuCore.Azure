
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mesh
{
     public partial class AzureMeshNetworkTask : ExternalProcessTaskBase<AzureMeshNetworkTask>
     {
        
        /// <summary>
        /// Manage networks.
        /// </summary>
        public AzureMeshNetworkTask()
        {
            WithArguments("az mesh network");
        }

        protected override string Description { get; set; }
        
     }
}
