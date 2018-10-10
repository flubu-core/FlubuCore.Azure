
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayWafConfigTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayWafConfigTask>
     {
        
        /// <summary>
        /// Configure the settings of a web application firewall.
        /// </summary>
        public AzureNetworkApplicationGatewayWafConfigTask()
        {
            WithArguments("az network application-gateway waf-config");
        }

        protected override string Description { get; set; }
        
     }
}
