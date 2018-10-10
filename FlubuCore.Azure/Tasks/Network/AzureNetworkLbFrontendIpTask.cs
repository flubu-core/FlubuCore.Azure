
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbFrontendIpTask : ExternalProcessTaskBase<AzureNetworkLbFrontendIpTask>
     {
        
        /// <summary>
        /// Manage frontend IP addresses of a load balancer.
        /// </summary>
        public AzureNetworkLbFrontendIpTask()
        {
            WithArguments("az network lb frontend-ip");
        }

        protected override string Description { get; set; }
        
     }
}
