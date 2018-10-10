
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNsgTask : ExternalProcessTaskBase<AzureNetworkNsgTask>
     {
        
        /// <summary>
        /// Manage Azure Network Security Groups (NSGs).
        /// </summary>
        public AzureNetworkNsgTask()
        {
            WithArguments("az network nsg");
        }

        protected override string Description { get; set; }
        
     }
}
