
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cdn
{
     public partial class AzureCdnEndpointValidateCustomDomainTask : ExternalProcessTaskBase<AzureCdnEndpointValidateCustomDomainTask>
     {
        
        /// <summary>
        /// Validates the custom domain mapping to ensure it maps to the correct CDN endpoint in DNS.
        /// </summary>
        public AzureCdnEndpointValidateCustomDomainTask(string hostName = null ,  string name = null ,  string profileName = null ,  string resourceGroup = null)
        {
            WithArguments("az cdn endpoint validate-custom-domain");
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

WithArguments("--profile-name");
            if (!string.IsNullOrEmpty(profileName))
            {
                 WithArguments(profileName);
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
