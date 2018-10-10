
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkTrafficManagerProfileCheckDnsTask : ExternalProcessTaskBase<AzureNetworkTrafficManagerProfileCheckDnsTask>
     {
        
        /// <summary>
        /// Check the availability of a relative DNS name.
        /// </summary>
        public AzureNetworkTrafficManagerProfileCheckDnsTask(string name = null)
        {
            WithArguments("az network traffic-manager profile check-dns");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
