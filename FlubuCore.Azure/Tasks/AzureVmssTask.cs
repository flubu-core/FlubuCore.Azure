
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureVmssTask : ExternalProcessTaskBase<AzureVmssTask>
     {
        
        /// <summary>
        /// Manage groupings of virtual machines in an Azure Virtual Machine Scale Set (VMSS).
        /// </summary>
        public AzureVmssTask()
        {
            WithArguments("az vmss");
        }

        protected override string Description { get; set; }
        
     }
}
