
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdGroupMemberAddTask : ExternalProcessTaskBase<AzureAdGroupMemberAddTask>
     {
        
        /// <summary>
        /// Add a member to a group.
        /// </summary>
        public AzureAdGroupMemberAddTask(string group = null ,  string memberId = null)
        {
            WithArguments("az ad group member add");
WithArguments("--group");
            if (!string.IsNullOrEmpty(group))
            {
                 WithArguments(group);
            }

WithArguments("--member-id");
            if (!string.IsNullOrEmpty(memberId))
            {
                 WithArguments(memberId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Unmatched properties from the message are deserialized this collection.
        /// </summary>
        public AzureAdGroupMemberAddTask AdditionalProperties(string additionalProperties = null)
        {
            WithArguments("--additional-properties");
            if (!string.IsNullOrEmpty(additionalProperties))
            {
                 WithArguments(additionalProperties);
            }

            return this;
        }
     }
}
