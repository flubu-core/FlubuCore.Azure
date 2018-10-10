
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmNicAddTask : ExternalProcessTaskBase<AzureVmNicAddTask>
     {
        
        /// <summary>
        /// Add existing NICs to a VM.
        /// </summary>
        public AzureVmNicAddTask(string nics = null ,  string resourceGroup = null ,  string vmName = null)
        {
            WithArguments("az vm nic add");
WithArguments("--nics");
            if (!string.IsNullOrEmpty(nics))
            {
                 WithArguments(nics);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--vm-name");
            if (!string.IsNullOrEmpty(vmName))
            {
                 WithArguments(vmName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name or ID of the primary NIC. If missing, the first NIC in the list will be the primary.
        /// </summary>
        public AzureVmNicAddTask PrimaryNic(string primaryNic = null)
        {
            WithArguments("--primary-nic");
            if (!string.IsNullOrEmpty(primaryNic))
            {
                 WithArguments(primaryNic);
            }

            return this;
        }
     }
}
