
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Resource
{
     public partial class AzureResourceMoveTask : ExternalProcessTaskBase<AzureResourceMoveTask>
     {
        
        /// <summary>
        /// Moves resources from one resource group to another(can be under different subscription).
        /// </summary>
        public AzureResourceMoveTask(string destinationGroup = null ,  string ids = null)
        {
            WithArguments("az resource move");
WithArguments("--destination-group");
            if (!string.IsNullOrEmpty(destinationGroup))
            {
                 WithArguments(destinationGroup);
            }

WithArguments("--ids");
            if (!string.IsNullOrEmpty(ids))
            {
                 WithArguments(ids);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The destination subscription identifier.
        /// </summary>
        public AzureResourceMoveTask DestinationSubscriptionId(string destinationSubscriptionId = null)
        {
            WithArguments("--destination-subscription-id");
            if (!string.IsNullOrEmpty(destinationSubscriptionId))
            {
                 WithArguments(destinationSubscriptionId);
            }

            return this;
        }
     }
}
