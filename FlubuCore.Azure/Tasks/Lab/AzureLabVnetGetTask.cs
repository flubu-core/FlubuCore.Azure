
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabVnetGetTask : ExternalProcessTaskBase<AzureLabVnetGetTask>
     {
        
        /// <summary>
        /// Get virtual network.
        /// </summary>
        public AzureLabVnetGetTask(string labName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az lab vnet get");
WithArguments("--lab-name");
            if (!string.IsNullOrEmpty(labName))
            {
                 WithArguments(labName);
            }

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
        /// Specify the $expand query. Example: 'properties($expand=externalSubnets)'.
        /// </summary>
        public AzureLabVnetGetTask Expand(string expand = null)
        {
            WithArguments("--expand");
            if (!string.IsNullOrEmpty(expand))
            {
                 WithArguments(expand);
            }

            return this;
        }
     }
}
