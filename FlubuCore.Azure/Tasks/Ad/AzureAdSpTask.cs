
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdSpTask : ExternalProcessTaskBase<AzureAdSpTask>
     {
        
        /// <summary>
        /// Manage Azure Active Directory service principals for automation authentication.
        /// </summary>
        public AzureAdSpTask()
        {
            WithArguments("az ad sp");
        }

        protected override string Description { get; set; }
        
     }
}
