
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Tag
{
     public partial class AzureTagDeleteTask : ExternalProcessTaskBase<AzureTagDeleteTask>
     {
        
        /// <summary>
        /// Deletes a tag from the subscription.
        /// </summary>
        public AzureTagDeleteTask(string name = null)
        {
            WithArguments("az tag delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
