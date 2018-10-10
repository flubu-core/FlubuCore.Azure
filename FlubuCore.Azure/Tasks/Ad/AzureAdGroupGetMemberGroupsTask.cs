
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdGroupGetMemberGroupsTask : ExternalProcessTaskBase<AzureAdGroupGetMemberGroupsTask>
     {
        
        /// <summary>
        /// Gets a collection of object IDs of groups of which the specified group is a member.
        /// </summary>
        public AzureAdGroupGetMemberGroupsTask(string group = null)
        {
            WithArguments("az ad group get-member-groups");
WithArguments("--group");
            if (!string.IsNullOrEmpty(group))
            {
                 WithArguments(group);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Unmatched properties from the message are deserialized this collection.
        /// </summary>
        public AzureAdGroupGetMemberGroupsTask AdditionalProperties(string additionalProperties = null)
        {
            WithArguments("--additional-properties");
            if (!string.IsNullOrEmpty(additionalProperties))
            {
                 WithArguments(additionalProperties);
            }

            return this;
        }

        /// <summary>
        /// If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.
        /// </summary>
        public AzureAdGroupGetMemberGroupsTask SecurityEnabledOnly(string securityEnabledOnly = null)
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
