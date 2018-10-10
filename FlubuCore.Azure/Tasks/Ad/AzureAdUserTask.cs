
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdUserTask : ExternalProcessTaskBase<AzureAdUserTask>
     {
        
        /// <summary>
        /// Manage Azure Active Directory users and user authentication.
        /// </summary>
        public AzureAdUserTask()
        {
            WithArguments("az ad user");
        }

        protected override string Description { get; set; }
        
     }
}
