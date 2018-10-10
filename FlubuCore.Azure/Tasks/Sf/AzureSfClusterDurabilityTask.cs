
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterDurabilityTask : ExternalProcessTaskBase<AzureSfClusterDurabilityTask>
     {
        
        /// <summary>
        /// Manage the durability of a cluster.
        /// </summary>
        public AzureSfClusterDurabilityTask()
        {
            WithArguments("az sf cluster durability");
        }

        protected override string Description { get; set; }
        
     }
}
