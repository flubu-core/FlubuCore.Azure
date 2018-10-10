
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Resource
{
     public partial class AzureResourceLinkUpdateTask : ExternalProcessTaskBase<AzureResourceLinkUpdateTask>
     {
        
        /// <summary>
        /// Update link between resources.
        /// </summary>
        public AzureResourceLinkUpdateTask(string linkId = null)
        {
            WithArguments("az resource link update");
WithArguments("--link-id");
            if (!string.IsNullOrEmpty(linkId))
            {
                 WithArguments(linkId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Notes for this link.
        /// </summary>
        public AzureResourceLinkUpdateTask Notes(string notes = null)
        {
            WithArguments("--notes");
            if (!string.IsNullOrEmpty(notes))
            {
                 WithArguments(notes);
            }

            return this;
        }

        /// <summary>
        /// The id of the resource link target.
        /// </summary>
        public AzureResourceLinkUpdateTask TargetId(string targetId = null)
        {
            WithArguments("--target-id");
            if (!string.IsNullOrEmpty(targetId))
            {
                 WithArguments(targetId);
            }

            return this;
        }
     }
}
