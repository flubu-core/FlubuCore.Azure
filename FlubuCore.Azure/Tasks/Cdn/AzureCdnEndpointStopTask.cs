
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cdn
{
     public partial class AzureCdnEndpointStopTask : ExternalProcessTaskBase<AzureCdnEndpointStopTask>
     {
        
        /// <summary>
        /// Stop a CDN endpoint.
        /// </summary>
        public AzureCdnEndpointStopTask(string name = null ,  string profileName = null ,  string resourceGroup = null)
        {
            WithArguments("az cdn endpoint stop");
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
