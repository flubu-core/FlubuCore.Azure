
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acs
{
     public partial class AzureAcsScaleTask : ExternalProcessTaskBase<AzureAcsScaleTask>
     {
        
        /// <summary>
        /// Change the private agent count of a container service.
        /// </summary>
        public AzureAcsScaleTask(string name = null ,  string newAgentCount = null ,  string resourceGroup = null)
        {
            WithArguments("az acs scale");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--new-agent-count");
            if (!string.IsNullOrEmpty(newAgentCount))
            {
                 WithArguments(newAgentCount);
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
