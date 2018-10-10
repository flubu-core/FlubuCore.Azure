
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureNetworkTask : ExternalProcessTaskBase<AzureNetworkTask>
     {
        
        /// <summary>
        /// Manage Azure Network resources.
        /// </summary>
        public AzureNetworkTask()
        {
            WithArguments("az network");
        }

        protected override string Description { get; set; }
        
     }
}
