
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mesh
{
     public partial class AzureMeshServiceTask : ExternalProcessTaskBase<AzureMeshServiceTask>
     {
        
        /// <summary>
        /// Manage Service Fabric Mesh services.
        /// </summary>
        public AzureMeshServiceTask()
        {
            WithArguments("az mesh service");
        }

        protected override string Description { get; set; }
        
     }
}
