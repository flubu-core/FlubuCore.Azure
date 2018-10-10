
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssNicTask : ExternalProcessTaskBase<AzureVmssNicTask>
     {
        
        /// <summary>
        /// Manage network interfaces of a VMSS.
        /// </summary>
        public AzureVmssNicTask()
        {
            WithArguments("az vmss nic");
        }

        protected override string Description { get; set; }
        
     }
}
