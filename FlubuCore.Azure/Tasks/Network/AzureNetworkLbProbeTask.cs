
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbProbeTask : ExternalProcessTaskBase<AzureNetworkLbProbeTask>
     {
        
        /// <summary>
        /// Evaluate probe information and define routing rules.
        /// </summary>
        public AzureNetworkLbProbeTask()
        {
            WithArguments("az network lb probe");
        }

        protected override string Description { get; set; }
        
     }
}
