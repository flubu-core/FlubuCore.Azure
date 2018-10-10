
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdAppTask : ExternalProcessTaskBase<AzureAdAppTask>
     {
        
        /// <summary>
        /// Manage applications with AAD Graph.
        /// </summary>
        public AzureAdAppTask()
        {
            WithArguments("az ad app");
        }

        protected override string Description { get; set; }
        
     }
}
