
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventgrid
{
     public partial class AzureEventgridTopicTypeTask : ExternalProcessTaskBase<AzureEventgridTopicTypeTask>
     {
        
        /// <summary>
        /// Get details for topic types.
        /// </summary>
        public AzureEventgridTopicTypeTask()
        {
            WithArguments("az eventgrid topic-type");
        }

        protected override string Description { get; set; }
        
     }
}
