
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureResourceTask : ExternalProcessTaskBase<AzureResourceTask>
     {
        
        /// <summary>
        /// Manage Azure resources.
        /// </summary>
        public AzureResourceTask()
        {
            WithArguments("az resource");
        }

        protected override string Description { get; set; }
        
     }
}
