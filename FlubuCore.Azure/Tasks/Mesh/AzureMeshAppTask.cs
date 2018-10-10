
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mesh
{
     public partial class AzureMeshAppTask : ExternalProcessTaskBase<AzureMeshAppTask>
     {
        
        /// <summary>
        /// Manage Service Fabric Mesh applications.
        /// </summary>
        public AzureMeshAppTask()
        {
            WithArguments("az mesh app");
        }

        protected override string Description { get; set; }
        
     }
}
