
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewaySslPolicyTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewaySslPolicyTask>
     {
        
        /// <summary>
        /// Manage the SSL policy of an application gateway.
        /// </summary>
        public AzureNetworkApplicationGatewaySslPolicyTask()
        {
            WithArguments("az network application-gateway ssl-policy");
        }

        protected override string Description { get; set; }
        
     }
}
