
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayHttpSettingsTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayHttpSettingsTask>
     {
        
        /// <summary>
        /// Manage HTTP settings of an application gateway.
        /// </summary>
        public AzureNetworkApplicationGatewayHttpSettingsTask()
        {
            WithArguments("az network application-gateway http-settings");
        }

        protected override string Description { get; set; }
        
     }
}
