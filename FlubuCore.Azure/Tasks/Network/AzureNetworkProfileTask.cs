
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkProfileTask : ExternalProcessTaskBase<AzureNetworkProfileTask>
     {
        
        /// <summary>
        /// Manage network profiles.
        /// </summary>
        public AzureNetworkProfileTask()
        {
            WithArguments("az network profile");
        }

        protected override string Description { get; set; }
        
     }
}
