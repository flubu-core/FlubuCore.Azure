
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmEncryptionTask : ExternalProcessTaskBase<AzureVmEncryptionTask>
     {
        
        /// <summary>
        /// Manage encryption of VM disks.
        /// </summary>
        public AzureVmEncryptionTask()
        {
            WithArguments("az vm encryption");
        }

        protected override string Description { get; set; }
        
     }
}
