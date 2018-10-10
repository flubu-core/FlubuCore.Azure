
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Resource
{
     public partial class AzureResourceLinkTask : ExternalProcessTaskBase<AzureResourceLinkTask>
     {
        
        /// <summary>
        /// Manage links between resources.
        /// </summary>
        public AzureResourceLinkTask()
        {
            WithArguments("az resource link");
        }

        protected override string Description { get; set; }
        
     }
}
