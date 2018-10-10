
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmAemDeleteTask : ExternalProcessTaskBase<AzureVmAemDeleteTask>
     {
        
        /// <summary>
        /// Remove Azure Enhanced Monitoring Extension.
        /// </summary>
        public AzureVmAemDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm aem delete");
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
