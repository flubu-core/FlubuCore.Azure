
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdGroupMemberRemoveTask : ExternalProcessTaskBase<AzureAdGroupMemberRemoveTask>
     {
        
        /// <summary>
        /// Remove a member from a group.
        /// </summary>
        public AzureAdGroupMemberRemoveTask(string group = null ,  string memberId = null)
        {
            WithArguments("az ad group member remove");
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
