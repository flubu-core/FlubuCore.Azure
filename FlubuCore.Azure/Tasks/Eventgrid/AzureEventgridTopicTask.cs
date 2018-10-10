
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventgrid
{
     public partial class AzureEventgridTopicTask : ExternalProcessTaskBase<AzureEventgridTopicTask>
     {
        
        /// <summary>
        /// Manage Azure Event Grid topics.
        /// </summary>
        public AzureEventgridTopicTask()
        {
            WithArguments("az eventgrid topic");
        }

        protected override string Description { get; set; }
        
     }
}
