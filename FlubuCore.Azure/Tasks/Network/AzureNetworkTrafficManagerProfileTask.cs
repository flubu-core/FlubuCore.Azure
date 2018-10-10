
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkTrafficManagerProfileTask : ExternalProcessTaskBase<AzureNetworkTrafficManagerProfileTask>
     {
        
        /// <summary>
        /// Manage Azure Traffic Manager profiles.
        /// </summary>
        public AzureNetworkTrafficManagerProfileTask()
        {
            WithArguments("az network traffic-manager profile");
        }

        protected override string Description { get; set; }
        
     }
}
