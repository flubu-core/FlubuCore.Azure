
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDdosProtectionCreateTask : ExternalProcessTaskBase<AzureNetworkDdosProtectionCreateTask>
     {
        
        /// <summary>
        /// Create a DDoS protection plan.
        /// </summary>
        public AzureNetworkDdosProtectionCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network ddos-protection create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkDdosProtectionCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkDdosProtectionCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of VNets (name or IDs) to associate with the plan.
        /// </summary>
        public AzureNetworkDdosProtectionCreateTask Vnets(string vnets = null)
        {
            WithArguments("--vnets");
            if (!string.IsNullOrEmpty(vnets))
            {
                 WithArguments(vnets);
            }

            return this;
        }
     }
}
