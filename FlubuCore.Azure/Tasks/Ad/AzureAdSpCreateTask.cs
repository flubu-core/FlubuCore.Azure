
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdSpCreateTask : ExternalProcessTaskBase<AzureAdSpCreateTask>
     {
        
        /// <summary>
        /// Create a service principal.
        /// </summary>
        public AzureAdSpCreateTask(string id = null)
        {
            WithArguments("az ad sp create");
WithArguments("--id");
            if (!string.IsNullOrEmpty(id))
            {
                 WithArguments(id);
            }

        }

        protected override string Description { get; set; }
        
     }
}
