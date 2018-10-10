
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Search
{
     public partial class AzureSearchQueryKeyTask : ExternalProcessTaskBase<AzureSearchQueryKeyTask>
     {
        
        /// <summary>
        /// Manage Azure Search query keys.
        /// </summary>
        public AzureSearchQueryKeyTask()
        {
            WithArguments("az search query-key");
        }

        protected override string Description { get; set; }
        
     }
}
