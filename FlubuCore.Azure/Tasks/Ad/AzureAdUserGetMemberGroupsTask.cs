
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdUserGetMemberGroupsTask : ExternalProcessTaskBase<AzureAdUserGetMemberGroupsTask>
     {
        
        /// <summary>
        /// Get groups of which the user is a member.
        /// </summary>
        public AzureAdUserGetMemberGroupsTask(string upnOrObjectId = null)
        {
            WithArguments("az ad user get-member-groups");
WithArguments("--upn-or-object-id");
            if (!string.IsNullOrEmpty(upnOrObjectId))
            {
                 WithArguments(upnOrObjectId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.
        /// </summary>
        public AzureAdUserGetMemberGroupsTask SecurityEnabledOnly(string securityEnabledOnly = null)
        {
            WithArguments("--security-enabled-only");
            if (!string.IsNullOrEmpty(securityEnabledOnly))
            {
                 WithArguments(securityEnabledOnly);
            }

            return this;
        }
     }
}
