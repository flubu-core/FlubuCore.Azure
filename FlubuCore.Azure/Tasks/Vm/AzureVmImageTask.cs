
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmImageTask : ExternalProcessTaskBase<AzureVmImageTask>
     {
        
        /// <summary>
        /// Information on available virtual machine images.
        /// </summary>
        public AzureVmImageTask()
        {
            WithArguments("az vm image");
        }

        protected override string Description { get; set; }
        
     }
}
