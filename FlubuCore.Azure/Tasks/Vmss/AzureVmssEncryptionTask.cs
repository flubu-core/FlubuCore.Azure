
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssEncryptionTask : ExternalProcessTaskBase<AzureVmssEncryptionTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage encryption of VMSS.
        /// </summary>
        public AzureVmssEncryptionTask()
        {
            WithArguments("az vmss encryption");
        }

        protected override string Description { get; set; }
        
     }
}
