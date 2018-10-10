
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Search
{
     public partial class AzureSearchServiceTask : ExternalProcessTaskBase<AzureSearchServiceTask>
     {
        
        /// <summary>
        /// Manage Azure Search services.
        /// </summary>
        public AzureSearchServiceTask()
        {
            WithArguments("az search service");
        }

        protected override string Description { get; set; }
        
     }
}
