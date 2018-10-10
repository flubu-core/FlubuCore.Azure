
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmIdentityTask : ExternalProcessTaskBase<AzureVmIdentityTask>
     {
        
        /// <summary>
        /// Manage service identities of a VM.
        /// </summary>
        public AzureVmIdentityTask()
        {
            WithArguments("az vm identity");
        }

        protected override string Description { get; set; }
        
     }
}
