
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureEventgridTask : ExternalProcessTaskBase<AzureEventgridTask>
     {
        
        /// <summary>
        /// Manage Azure Event Grid topics and subscriptions.
        /// </summary>
        public AzureEventgridTask()
        {
            WithArguments("az eventgrid");
        }

        protected override string Description { get; set; }
        
     }
}
