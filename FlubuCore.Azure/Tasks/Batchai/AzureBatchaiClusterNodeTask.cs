
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiClusterNodeTask : ExternalProcessTaskBase<AzureBatchaiClusterNodeTask>
     {
        
        /// <summary>
        /// Commands to work with cluster nodes.
        /// </summary>
        public AzureBatchaiClusterNodeTask()
        {
            WithArguments("az batchai cluster node");
        }

        protected override string Description { get; set; }
        
     }
}
