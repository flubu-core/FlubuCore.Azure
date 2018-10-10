
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmSecretTask : ExternalProcessTaskBase<AzureVmSecretTask>
     {
        
        /// <summary>
        /// Manage VM secrets.
        /// </summary>
        public AzureVmSecretTask()
        {
            WithArguments("az vm secret");
        }

        protected override string Description { get; set; }
        
     }
}
