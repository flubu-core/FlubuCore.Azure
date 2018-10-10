
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mesh
{
     public partial class AzureMeshVolumeTask : ExternalProcessTaskBase<AzureMeshVolumeTask>
     {
        
        /// <summary>
        /// Manage volumes.
        /// </summary>
        public AzureMeshVolumeTask()
        {
            WithArguments("az mesh volume");
        }

        protected override string Description { get; set; }
        
     }
}
