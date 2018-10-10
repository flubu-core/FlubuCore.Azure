
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssExtensionDeleteTask : ExternalProcessTaskBase<AzureVmssExtensionDeleteTask>
     {
        
        /// <summary>
        /// Delete an extension from a VMSS.
        /// </summary>
        public AzureVmssExtensionDeleteTask(string name = null ,  string resourceGroup = null ,  string vmssName = null)
        {
            WithArguments("az vmss extension delete");
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

WithArguments("--vmss-name");
            if (!string.IsNullOrEmpty(vmssName))
            {
                 WithArguments(vmssName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureVmssExtensionDeleteTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }
     }
}
