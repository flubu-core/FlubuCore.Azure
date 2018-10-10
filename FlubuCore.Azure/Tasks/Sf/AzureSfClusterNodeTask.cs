
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterNodeTask : ExternalProcessTaskBase<AzureSfClusterNodeTask>
     {
        
        /// <summary>
        /// Manage the node instance of a cluster.
        /// </summary>
        public AzureSfClusterNodeTask()
        {
            WithArguments("az sf cluster node");
        }

        protected override string Description { get; set; }
        
     }
}
