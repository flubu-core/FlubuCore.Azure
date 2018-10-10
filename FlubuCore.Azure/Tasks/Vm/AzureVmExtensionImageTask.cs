
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmExtensionImageTask : ExternalProcessTaskBase<AzureVmExtensionImageTask>
     {
        
        /// <summary>
        /// Find the available VM extensions for a subscription and region.
        /// </summary>
        public AzureVmExtensionImageTask()
        {
            WithArguments("az vm extension image");
        }

        protected override string Description { get; set; }
        
     }
}
