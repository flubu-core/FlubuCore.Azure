
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiClusterTask : ExternalProcessTaskBase<AzureBatchaiClusterTask>
     {
        
        /// <summary>
        /// Commands to manage clusters.
        /// </summary>
        public AzureBatchaiClusterTask()
        {
            WithArguments("az batchai cluster");
        }

        protected override string Description { get; set; }
        
     }
}
