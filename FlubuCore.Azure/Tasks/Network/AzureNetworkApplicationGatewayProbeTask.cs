
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayProbeTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayProbeTask>
     {
        
        /// <summary>
        /// Manage probes to gather and evaluate information on a gateway.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeTask()
        {
            WithArguments("az network application-gateway probe");
        }

        protected override string Description { get; set; }
        
     }
}
