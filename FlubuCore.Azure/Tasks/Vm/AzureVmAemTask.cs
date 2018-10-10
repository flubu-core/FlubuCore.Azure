
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmAemTask : ExternalProcessTaskBase<AzureVmAemTask>
     {
        
        /// <summary>
        /// Manage Azure Enhanced Monitoring Extension for SAP.
        /// </summary>
        public AzureVmAemTask()
        {
            WithArguments("az vm aem");
        }

        protected override string Description { get; set; }
        
     }
}
