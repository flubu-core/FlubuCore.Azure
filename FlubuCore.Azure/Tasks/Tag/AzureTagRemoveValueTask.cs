
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Tag
{
     public partial class AzureTagRemoveValueTask : ExternalProcessTaskBase<AzureTagRemoveValueTask>
     {
        
        /// <summary>
        /// Deletes a tag value.
        /// </summary>
        public AzureTagRemoveValueTask(string name = null ,  string value = null)
        {
            WithArguments("az tag remove-value");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--value");
            if (!string.IsNullOrEmpty(value))
            {
                 WithArguments(value);
            }

        }

        protected override string Description { get; set; }
        
     }
}
