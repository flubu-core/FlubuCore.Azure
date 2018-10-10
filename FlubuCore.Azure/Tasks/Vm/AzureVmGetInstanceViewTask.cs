
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmGetInstanceViewTask : ExternalProcessTaskBase<AzureVmGetInstanceViewTask>
     {
        
        /// <summary>
        /// Get instance information about a VM.
        /// </summary>
        public AzureVmGetInstanceViewTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm get-instance-view");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
