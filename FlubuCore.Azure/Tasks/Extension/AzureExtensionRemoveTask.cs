
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Extension
{
     public partial class AzureExtensionRemoveTask : ExternalProcessTaskBase<AzureExtensionRemoveTask>
     {
        
        /// <summary>
        /// Remove an extension.
        /// </summary>
        public AzureExtensionRemoveTask(string name = null)
        {
            WithArguments("az extension remove");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
