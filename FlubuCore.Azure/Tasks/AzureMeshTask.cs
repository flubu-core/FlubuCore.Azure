
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureMeshTask : ExternalProcessTaskBase<AzureMeshTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Azure Service Fabric Mesh Resources.
        /// </summary>
        public AzureMeshTask()
        {
            WithArguments("az mesh");
        }

        protected override string Description { get; set; }
        
     }
}
