
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVhubConnectionCreateTask : ExternalProcessTaskBase<AzureNetworkVhubConnectionCreateTask>
     {
        
        /// <summary>
        /// Create a virtual hub VNet connection.
        /// </summary>
        public AzureNetworkVhubConnectionCreateTask(string name = null ,  string remoteVnet = null ,  string resourceGroup = null ,  string vhubName = null)
        {
            WithArguments("az network vhub connection create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--remote-vnet");
            if (!string.IsNullOrEmpty(remoteVnet))
            {
                 WithArguments(remoteVnet);
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
        /// Enable internet security.
        /// </summary>
        public AzureNetworkVhubConnectionCreateTask InternetSecurity(string internetSecurity = null)
        {
            WithArguments("--internet-security");
            if (!string.IsNullOrEmpty(internetSecurity))
            {
                 WithArguments(internetSecurity);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkVhubConnectionCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Enable hub to remote VNet transit.
        /// </summary>
        public AzureNetworkVhubConnectionCreateTask RemoteVnetTransit(string remoteVnetTransit = null)
        {
            WithArguments("--remote-vnet-transit");
            if (!string.IsNullOrEmpty(remoteVnetTransit))
            {
                 WithArguments(remoteVnetTransit);
            }

            return this;
        }

        /// <summary>
        /// Allow remote VNet to use hub's VNet gateways.
        /// </summary>
        public AzureNetworkVhubConnectionCreateTask UseHubVnetGateways(string useHubVnetGateways = null)
        {
            WithArguments("--use-hub-vnet-gateways");
            if (!string.IsNullOrEmpty(useHubVnetGateways))
            {
                 WithArguments(useHubVnetGateways);
            }

            return this;
        }
     }
}
