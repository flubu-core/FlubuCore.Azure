
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ad
{
     public partial class AzureAdGroupDeleteTask : ExternalProcessTaskBase<AzureAdGroupDeleteTask>
     {
        
        /// <summary>
        /// Delete a group from the directory.
        /// </summary>
        public AzureAdGroupDeleteTask(string group = null)
        {
            WithArguments("az ad group delete");
WithArguments("--group");
            if (!string.IsNullOrEmpty(group))
            {
                 WithArguments(group);
            }

        }

        protected override string Description { get; set; }
        
     }
}
