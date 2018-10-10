
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaAccountComputePolicyTask : ExternalProcessTaskBase<AzureDlaAccountComputePolicyTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics account compute policies.
        /// </summary>
        public AzureDlaAccountComputePolicyTask()
        {
            WithArguments("az dla account compute-policy");
        }

        protected override string Description { get; set; }
        
     }
}
