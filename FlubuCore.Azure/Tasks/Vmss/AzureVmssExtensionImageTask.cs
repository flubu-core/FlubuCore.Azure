
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssExtensionImageTask : ExternalProcessTaskBase<AzureVmssExtensionImageTask>
     {
        
        /// <summary>
        /// Find the available VM extensions for a subscription and region.
        /// </summary>
        public AzureVmssExtensionImageTask()
        {
            WithArguments("az vmss extension image");
        }

        protected override string Description { get; set; }
        
     }
}
