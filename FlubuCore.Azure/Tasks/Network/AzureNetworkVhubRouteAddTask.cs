
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVhubRouteAddTask : ExternalProcessTaskBase<AzureNetworkVhubRouteAddTask>
     {
        
        /// <summary>
        /// Add a route to the virtual hub route table.
        /// </summary>
        public AzureNetworkVhubRouteAddTask(string addressPrefixes = null ,  string nextHop = null ,  string resourceGroup = null ,  string vhubName = null)
        {
            WithArguments("az network vhub route add");
WithArguments("--address-prefixes");
            if (!string.IsNullOrEmpty(addressPrefixes))
            {
                 WithArguments(addressPrefixes);
            }

WithArguments("--next-hop");
            if (!string.IsNullOrEmpty(nextHop))
            {
                 WithArguments(nextHop);
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
        public AzureNetworkVhubRouteAddTask NoWait(string noWait = null)
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
