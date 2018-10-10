
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventgrid
{
     public partial class AzureEventgridTopicKeyTask : ExternalProcessTaskBase<AzureEventgridTopicKeyTask>
     {
        
        /// <summary>
        /// Manage shared access keys of a topic.
        /// </summary>
        public AzureEventgridTopicKeyTask()
        {
            WithArguments("az eventgrid topic key");
        }

        protected override string Description { get; set; }
        
     }
}
