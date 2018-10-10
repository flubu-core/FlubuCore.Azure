
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cdn
{
     public partial class AzureCdnCustomDomainEnableHttpsTask : ExternalProcessTaskBase<AzureCdnCustomDomainEnableHttpsTask>
     {
        
        /// <summary>
        /// Enable https delivery of the custom domain.
        /// </summary>
        public AzureCdnCustomDomainEnableHttpsTask(string endpointName = null ,  string name = null ,  string profileName = null ,  string resourceGroup = null)
        {
            WithArguments("az cdn custom-domain enable-https");
WithArguments("--endpoint-name");
            if (!string.IsNullOrEmpty(endpointName))
            {
                 WithArguments(endpointName);
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
