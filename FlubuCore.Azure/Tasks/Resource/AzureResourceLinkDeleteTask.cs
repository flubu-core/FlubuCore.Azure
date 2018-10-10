
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Resource
{
     public partial class AzureResourceLinkDeleteTask : ExternalProcessTaskBase<AzureResourceLinkDeleteTask>
     {
        
        /// <summary>
        /// Delete a link between resources.
        /// </summary>
        public AzureResourceLinkDeleteTask(string linkId = null)
        {
            WithArguments("az resource link delete");
WithArguments("--link-id");
            if (!string.IsNullOrEmpty(linkId))
            {
                 WithArguments(linkId);
            }

        }

        protected override string Description { get; set; }
        
     }
}
