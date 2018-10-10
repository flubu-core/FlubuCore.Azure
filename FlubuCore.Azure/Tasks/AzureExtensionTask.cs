
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureExtensionTask : ExternalProcessTaskBase<AzureExtensionTask>
     {
        
        /// <summary>
        /// Manage and update CLI extensions.
        /// </summary>
        public AzureExtensionTask()
        {
            WithArguments("az extension");
        }

        protected override string Description { get; set; }
        
     }
}
