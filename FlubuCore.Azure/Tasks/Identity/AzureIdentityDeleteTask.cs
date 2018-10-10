
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Identity
{
     public partial class AzureIdentityDeleteTask : ExternalProcessTaskBase<AzureIdentityDeleteTask>
     {
        
        /// <summary>
        /// Deletes the identity.
        /// </summary>
        public AzureIdentityDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az identity delete");
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
