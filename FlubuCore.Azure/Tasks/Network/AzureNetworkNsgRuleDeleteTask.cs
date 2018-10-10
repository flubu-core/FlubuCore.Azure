
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNsgRuleDeleteTask : ExternalProcessTaskBase<AzureNetworkNsgRuleDeleteTask>
     {
        
        /// <summary>
        /// Delete a network security group rule.
        /// </summary>
        public AzureNetworkNsgRuleDeleteTask(string name = null ,  string nsgName = null ,  string resourceGroup = null)
        {
            WithArguments("az network nsg rule delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--nsg-name");
            if (!string.IsNullOrEmpty(nsgName))
            {
                 WithArguments(nsgName);
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
