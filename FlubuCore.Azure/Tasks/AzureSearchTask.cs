
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureSearchTask : ExternalProcessTaskBase<AzureSearchTask>
     {
        
        /// <summary>
        /// Manage Azure Search services, admin keys and query keys.
        /// </summary>
        public AzureSearchTask()
        {
            WithArguments("az search");
        }

        protected override string Description { get; set; }
        
     }
}
