
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterNodeTypeTask : ExternalProcessTaskBase<AzureSfClusterNodeTypeTask>
     {
        
        /// <summary>
        /// Manage the node-type of a cluster.
        /// </summary>
        public AzureSfClusterNodeTypeTask()
        {
            WithArguments("az sf cluster node-type");
        }

        protected override string Description { get; set; }
        
     }
}
