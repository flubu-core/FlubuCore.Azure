
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssIdentityTask : ExternalProcessTaskBase<AzureVmssIdentityTask>
     {
        
        /// <summary>
        /// Manage service identities of a VM scaleset.
        /// </summary>
        public AzureVmssIdentityTask()
        {
            WithArguments("az vmss identity");
        }

        protected override string Description { get; set; }
        
     }
}
