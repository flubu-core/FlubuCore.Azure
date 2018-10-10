
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureFindTask : ExternalProcessTaskBase<AzureFindTask>
     {
        
        /// <summary>
        /// Find Azure CLI commands.
        /// </summary>
        public AzureFindTask(string searchQuery = null)
        {
            WithArguments("az find");
WithArguments("--search-query");
            if (!string.IsNullOrEmpty(searchQuery))
            {
                 WithArguments(searchQuery);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Clear the current index and reindex the command modules.
        /// </summary>
        public AzureFindTask Reindex(string reindex = null)
        {
            WithArguments("--reindex");
            if (!string.IsNullOrEmpty(reindex))
            {
                 WithArguments(reindex);
            }

            return this;
        }
     }
}
