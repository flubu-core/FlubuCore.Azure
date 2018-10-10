
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorCheckCustomDomainTask : ExternalProcessTaskBase<AzureNetworkFrontDoorCheckCustomDomainTask>
     {
        
        /// <summary>
        /// Validates the custom domain mapping to ensure it maps to the correct Front Door endpoint in DNS.
        /// </summary>
        public AzureNetworkFrontDoorCheckCustomDomainTask(string hostName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network front-door check-custom-domain");
WithArguments("--host-name");
            if (!string.IsNullOrEmpty(hostName))
            {
                 WithArguments(hostName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
