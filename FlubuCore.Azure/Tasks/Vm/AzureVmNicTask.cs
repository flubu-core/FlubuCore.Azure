
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmNicTask : ExternalProcessTaskBase<AzureVmNicTask>
     {
        
        /// <summary>
        /// Manage network interfaces. See also `az network nic`.
        /// </summary>
        public AzureVmNicTask()
        {
            WithArguments("az vm nic");
        }

        protected override string Description { get; set; }
        
     }
}
