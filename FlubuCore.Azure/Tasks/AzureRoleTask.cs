
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureRoleTask : ExternalProcessTaskBase<AzureRoleTask>
     {
        
        /// <summary>
        /// Manage user roles for access control with Azure Active Directory and service principals.
        /// </summary>
        public AzureRoleTask()
        {
            WithArguments("az role");
        }

        protected override string Description { get; set; }
        
     }
}
