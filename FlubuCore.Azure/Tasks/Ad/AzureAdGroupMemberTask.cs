
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdGroupMemberTask : ExternalProcessTaskBase<AzureAdGroupMemberTask>
     {
        
        /// <summary>
        /// Manage Azure Active Directory group members.
        /// </summary>
        public AzureAdGroupMemberTask()
        {
            WithArguments("az ad group member");
        }

        protected override string Description { get; set; }
        
     }
}
