
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultNetworkRuleTask : ExternalProcessTaskBase<AzureKeyvaultNetworkRuleTask>
     {
        
        /// <summary>
        /// Manage vault network ACLs.
        /// </summary>
        public AzureKeyvaultNetworkRuleTask()
        {
            WithArguments("az keyvault network-rule");
        }

        protected override string Description { get; set; }
        
     }
}
