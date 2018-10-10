
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmAvailabilitySetTask : ExternalProcessTaskBase<AzureVmAvailabilitySetTask>
     {
        
        /// <summary>
        /// Group resources into availability sets.
        /// </summary>
        public AzureVmAvailabilitySetTask()
        {
            WithArguments("az vm availability-set");
        }

        protected override string Description { get; set; }
        
     }
}
