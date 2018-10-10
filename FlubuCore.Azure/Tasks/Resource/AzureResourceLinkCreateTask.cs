
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Resource
{
     public partial class AzureResourceLinkCreateTask : ExternalProcessTaskBase<AzureResourceLinkCreateTask>
     {
        
        /// <summary>
        /// Create a new link between resources.
        /// </summary>
        public AzureResourceLinkCreateTask(string linkId = null ,  string targetId = null)
        {
            WithArguments("az resource link create");
WithArguments("--link-id");
            if (!string.IsNullOrEmpty(linkId))
            {
                 WithArguments(linkId);
            }

WithArguments("--target-id");
            if (!string.IsNullOrEmpty(targetId))
            {
                 WithArguments(targetId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Notes for this link.
        /// </summary>
        public AzureResourceLinkCreateTask Notes(string notes = null)
        {
            WithArguments("--notes");
            if (!string.IsNullOrEmpty(notes))
            {
                 WithArguments(notes);
            }

            return this;
        }
     }
}
