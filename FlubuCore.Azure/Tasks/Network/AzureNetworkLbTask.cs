
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbTask : ExternalProcessTaskBase<AzureNetworkLbTask>
     {
        
        /// <summary>
        /// Manage and configure load balancers.
        /// </summary>
        public AzureNetworkLbTask()
        {
            WithArguments("az network lb");
        }

        protected override string Description { get; set; }
        
     }
}
