
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkCrossConnectionSummarizeRouteTableTask : ExternalProcessTaskBase<AzureNetworkCrossConnectionSummarizeRouteTableTask>
     {
        
        /// <summary>
        /// Gets the route table summary associated with the express route cross connection in a resource group.
        /// </summary>
        public AzureNetworkCrossConnectionSummarizeRouteTableTask(string devicePath = null ,  string name = null ,  string peeringName = null ,  string resourceGroup = null)
        {
            WithArguments("az network cross-connection summarize-route-table");
WithArguments("--device-path");
            if (!string.IsNullOrEmpty(devicePath))
            {
                 WithArguments(devicePath);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--peering-name");
            if (!string.IsNullOrEmpty(peeringName))
            {
                 WithArguments(peeringName);
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
