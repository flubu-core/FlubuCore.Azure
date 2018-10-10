
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmUserTask : ExternalProcessTaskBase<AzureVmUserTask>
     {
        
        /// <summary>
        /// Manage user accounts for a VM.
        /// </summary>
        public AzureVmUserTask()
        {
            WithArguments("az vm user");
        }

        protected override string Description { get; set; }
        
     }
}
