
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbInboundNatPoolDeleteTask : ExternalProcessTaskBase<AzureNetworkLbInboundNatPoolDeleteTask>
     {
        
        /// <summary>
        /// Delete an inbound NAT address pool.
        /// </summary>
        public AzureNetworkLbInboundNatPoolDeleteTask(string lbName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network lb inbound-nat-pool delete");
WithArguments("--lb-name");
            if (!string.IsNullOrEmpty(lbName))
            {
                 WithArguments(lbName);
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
        
     }
}
