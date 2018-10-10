
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssExtensionTask : ExternalProcessTaskBase<AzureVmssExtensionTask>
     {
        
        /// <summary>
        /// Manage extensions on a VM scale set.
        /// </summary>
        public AzureVmssExtensionTask()
        {
            WithArguments("az vmss extension");
        }

        protected override string Description { get; set; }
        
     }
}
