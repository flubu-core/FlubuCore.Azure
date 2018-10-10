
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Maps
{
     public partial class AzureMapsAccountDeleteTask : ExternalProcessTaskBase<AzureMapsAccountDeleteTask>
     {
        
        /// <summary>
        /// Delete a maps account.
        /// </summary>
        public AzureMapsAccountDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az maps account delete");
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
