
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNicIpConfigAddressPoolRemoveTask : ExternalProcessTaskBase<AzureNetworkNicIpConfigAddressPoolRemoveTask>
     {
        
        /// <summary>
        /// Remove an address pool of an IP configuration.
        /// </summary>
        public AzureNetworkNicIpConfigAddressPoolRemoveTask(string addressPool = null ,  string ipConfigName = null ,  string nicName = null ,  string resourceGroup = null)
        {
            WithArguments("az network nic ip-config address-pool remove");
WithArguments("--address-pool");
            if (!string.IsNullOrEmpty(addressPool))
            {
                 WithArguments(addressPool);
            }

WithArguments("--ip-config-name");
            if (!string.IsNullOrEmpty(ipConfigName))
            {
                 WithArguments(ipConfigName);
            }

WithArguments("--nic-name");
            if (!string.IsNullOrEmpty(nicName))
            {
                 WithArguments(nicName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The name of the load balancer associated with the address pool (Omit if suppying an address pool ID).
        /// </summary>
        public AzureNetworkNicIpConfigAddressPoolRemoveTask LbName(string lbName = null)
        {
            WithArguments("--lb-name");
            if (!string.IsNullOrEmpty(lbName))
            {
                 WithArguments(lbName);
            }

            return this;
        }
     }
}
