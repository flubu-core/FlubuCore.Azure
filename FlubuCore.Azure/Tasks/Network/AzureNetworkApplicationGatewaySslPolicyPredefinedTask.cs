
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewaySslPolicyPredefinedTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewaySslPolicyPredefinedTask>
     {
        
        /// <summary>
        /// Get information on predefined SSL policies.
        /// </summary>
        public AzureNetworkApplicationGatewaySslPolicyPredefinedTask()
        {
            WithArguments("az network application-gateway ssl-policy predefined");
        }

        protected override string Description { get; set; }
        
     }
}
