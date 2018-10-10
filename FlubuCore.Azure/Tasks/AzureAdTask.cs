
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureAdTask : ExternalProcessTaskBase<AzureAdTask>
     {
        
        /// <summary>
        /// Manage Azure Active Directory Graph entities needed for Role Based Access Control.
        /// </summary>
        public AzureAdTask()
        {
            WithArguments("az ad");
        }

        protected override string Description { get; set; }
        
     }
}
