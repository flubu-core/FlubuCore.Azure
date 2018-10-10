
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVhubRouteRemoveTask : ExternalProcessTaskBase<AzureNetworkVhubRouteRemoveTask>
     {
        
        /// <summary>
        /// Remove a route from the virtual hub route table.
        /// </summary>
        public AzureNetworkVhubRouteRemoveTask(string index = null ,  string resourceGroup = null ,  string vhubName = null)
        {
            WithArguments("az network vhub route remove");
WithArguments("--index");
            if (!string.IsNullOrEmpty(index))
            {
                 WithArguments(index);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--vhub-name");
            if (!string.IsNullOrEmpty(vhubName))
            {
                 WithArguments(vhubName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkVhubRouteRemoveTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }
     }
}
