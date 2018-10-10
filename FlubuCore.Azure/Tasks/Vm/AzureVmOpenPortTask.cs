
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmOpenPortTask : ExternalProcessTaskBase<AzureVmOpenPortTask>
     {
        
        /// <summary>
        /// Opens a VM to inbound traffic on specified ports.
        /// </summary>
        public AzureVmOpenPortTask(string name = null ,  string port = null ,  string resourceGroup = null)
        {
            WithArguments("az vm open-port");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--port");
            if (!string.IsNullOrEmpty(port))
            {
                 WithArguments(port);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Allow inbound traffic on the subnet instead of the NIC.
        /// </summary>
        public AzureVmOpenPortTask ApplyToSubnet(string applyToSubnet = null)
        {
            WithArguments("--apply-to-subnet");
            if (!string.IsNullOrEmpty(applyToSubnet))
            {
                 WithArguments(applyToSubnet);
            }

            return this;
        }

        /// <summary>
        /// The name of the network security group to create if one does not exist. Ignored if an NSG already exists.
        /// </summary>
        public AzureVmOpenPortTask NsgName(string nsgName = null)
        {
            WithArguments("--nsg-name");
            if (!string.IsNullOrEmpty(nsgName))
            {
                 WithArguments(nsgName);
            }

            return this;
        }

        /// <summary>
        /// Rule priority, between 100 (highest priority) and 4096 (lowest priority). Must be unique for each rule in the collection.
        /// </summary>
        public AzureVmOpenPortTask Priority(string priority = null)
        {
            WithArguments("--priority");
            if (!string.IsNullOrEmpty(priority))
            {
                 WithArguments(priority);
            }

            return this;
        }
     }
}
