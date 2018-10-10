
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssDiskTask : ExternalProcessTaskBase<AzureVmssDiskTask>
     {
        
        /// <summary>
        /// Manage data disks of a VMSS.
        /// </summary>
        public AzureVmssDiskTask()
        {
            WithArguments("az vmss disk");
        }

        protected override string Description { get; set; }
        
     }
}
