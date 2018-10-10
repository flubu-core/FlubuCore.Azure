
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdSpDeleteTask : ExternalProcessTaskBase<AzureAdSpDeleteTask>
     {
        
        /// <summary>
        /// Delete a service principal and its role assignments.
        /// </summary>
        public AzureAdSpDeleteTask(string id = null)
        {
            WithArguments("az ad sp delete");
WithArguments("--id");
            if (!string.IsNullOrEmpty(id))
            {
                 WithArguments(id);
            }

        }

        protected override string Description { get; set; }
        
     }
}
