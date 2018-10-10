
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewaySslCertTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewaySslCertTask>
     {
        
        /// <summary>
        /// Manage SSL certificates of an application gateway.
        /// </summary>
        public AzureNetworkApplicationGatewaySslCertTask()
        {
            WithArguments("az network application-gateway ssl-cert");
        }

        protected override string Description { get; set; }
        
     }
}
