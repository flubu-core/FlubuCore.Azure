
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherTestIpFlowTask : ExternalProcessTaskBase<AzureNetworkWatcherTestIpFlowTask>
     {
        
        /// <summary>
        /// Test IP flow to/from a VM given the currently configured network security group rules.
        /// </summary>
        public AzureNetworkWatcherTestIpFlowTask(string direction = null ,  string local = null ,  string protocol = null ,  string remote = null ,  string vm = null)
        {
            WithArguments("az network watcher test-ip-flow");
WithArguments("--direction");
            if (!string.IsNullOrEmpty(direction))
            {
                 WithArguments(direction);
            }

WithArguments("--local");
            if (!string.IsNullOrEmpty(local))
            {
                 WithArguments(local);
            }

WithArguments("--protocol");
            if (!string.IsNullOrEmpty(protocol))
            {
                 WithArguments(protocol);
            }

WithArguments("--remote");
            if (!string.IsNullOrEmpty(remote))
            {
                 WithArguments(remote);
            }

WithArguments("--vm");
            if (!string.IsNullOrEmpty(vm))
            {
                 WithArguments(vm);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name or ID of the NIC resource to test. If the VM has multiple NICs and IP forwarding is enabled on any of them, this parameter is required.
        /// </summary>
        public AzureNetworkWatcherTestIpFlowTask Nic(string nic = null)
        {
            WithArguments("--nic");
            if (!string.IsNullOrEmpty(nic))
            {
                 WithArguments(nic);
            }

            return this;
        }

        /// <summary>
        /// Name of the resource group the target VM is in. Do not use when supplying VM ID.
        /// </summary>
        public AzureNetworkWatcherTestIpFlowTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }
     }
}
