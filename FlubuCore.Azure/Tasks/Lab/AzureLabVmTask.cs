
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabVmTask : ExternalProcessTaskBase<AzureLabVmTask>
     {
        
        /// <summary>
        /// Manage VMs in an Azure DevTest Lab.
        /// </summary>
        public AzureLabVmTask()
        {
            WithArguments("az lab vm");
        }

        protected override string Description { get; set; }
        
     }
}
