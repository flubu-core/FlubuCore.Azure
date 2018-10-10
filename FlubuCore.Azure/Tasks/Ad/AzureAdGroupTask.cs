
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdGroupTask : ExternalProcessTaskBase<AzureAdGroupTask>
     {
        
        /// <summary>
        /// Manage Azure Active Directory groups.
        /// </summary>
        public AzureAdGroupTask()
        {
            WithArguments("az ad group");
        }

        protected override string Description { get; set; }
        
     }
}
