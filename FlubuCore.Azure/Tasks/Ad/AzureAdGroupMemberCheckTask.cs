
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdGroupMemberCheckTask : ExternalProcessTaskBase<AzureAdGroupMemberCheckTask>
     {
        
        /// <summary>
        /// Check if a member is in a group.
        /// </summary>
        public AzureAdGroupMemberCheckTask(string group = null ,  string memberId = null)
        {
            WithArguments("az ad group member check");
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
        
     }
}
