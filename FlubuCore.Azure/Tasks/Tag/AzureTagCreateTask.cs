
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Tag
{
     public partial class AzureTagCreateTask : ExternalProcessTaskBase<AzureTagCreateTask>
     {
        
        /// <summary>
        /// Creates a tag in the subscription.
        /// </summary>
        public AzureTagCreateTask(string name = null)
        {
            WithArguments("az tag create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
