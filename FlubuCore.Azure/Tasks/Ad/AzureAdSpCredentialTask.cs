
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdSpCredentialTask : ExternalProcessTaskBase<AzureAdSpCredentialTask>
     {
        
        /// <summary>
        /// Manage a service principal's credentials.
        /// </summary>
        public AzureAdSpCredentialTask()
        {
            WithArguments("az ad sp credential");
        }

        protected override string Description { get; set; }
        
     }
}
