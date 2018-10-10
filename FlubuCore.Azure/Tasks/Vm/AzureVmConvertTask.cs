
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmConvertTask : ExternalProcessTaskBase<AzureVmConvertTask>
     {
        
        /// <summary>
        /// Convert a VM with unmanaged disks to use managed disks.
        /// </summary>
        public AzureVmConvertTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm convert");
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
