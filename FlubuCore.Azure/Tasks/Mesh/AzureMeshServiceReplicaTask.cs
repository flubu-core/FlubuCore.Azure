
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mesh
{
     public partial class AzureMeshServiceReplicaTask : ExternalProcessTaskBase<AzureMeshServiceReplicaTask>
     {
        
        /// <summary>
        /// Manage Service Fabric Mesh service replicas.
        /// </summary>
        public AzureMeshServiceReplicaTask()
        {
            WithArguments("az mesh service-replica");
        }

        protected override string Description { get; set; }
        
     }
}
