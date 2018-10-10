
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterReliabilityTask : ExternalProcessTaskBase<AzureSfClusterReliabilityTask>
     {
        
        /// <summary>
        /// Manage the reliability of a cluster.
        /// </summary>
        public AzureSfClusterReliabilityTask()
        {
            WithArguments("az sf cluster reliability");
        }

        protected override string Description { get; set; }
        
     }
}
