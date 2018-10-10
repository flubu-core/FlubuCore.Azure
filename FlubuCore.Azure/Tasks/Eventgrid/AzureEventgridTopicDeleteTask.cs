
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventgrid
{
     public partial class AzureEventgridTopicDeleteTask : ExternalProcessTaskBase<AzureEventgridTopicDeleteTask>
     {
        
        /// <summary>
        /// Delete a topic.
        /// </summary>
        public AzureEventgridTopicDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az eventgrid topic delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
