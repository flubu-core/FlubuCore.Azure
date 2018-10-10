
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdAppDeleteTask : ExternalProcessTaskBase<AzureAdAppDeleteTask>
     {
        
        /// <summary>
        /// Delete an application.
        /// </summary>
        public AzureAdAppDeleteTask(string id = null)
        {
            WithArguments("az ad app delete");
WithArguments("--id");
            if (!string.IsNullOrEmpty(id))
            {
                 WithArguments(id);
            }

        }

        protected override string Description { get; set; }
        
     }
}
