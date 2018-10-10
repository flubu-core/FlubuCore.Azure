
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNsgRuleTask : ExternalProcessTaskBase<AzureNetworkNsgRuleTask>
     {
        
        /// <summary>
        /// Manage network security group rules.
        /// </summary>
        public AzureNetworkNsgRuleTask()
        {
            WithArguments("az network nsg rule");
        }

        protected override string Description { get; set; }
        
     }
}
