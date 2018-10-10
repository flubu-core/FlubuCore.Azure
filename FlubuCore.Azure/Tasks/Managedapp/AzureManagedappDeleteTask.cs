
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Managedapp
{
     public partial class AzureManagedappDeleteTask : ExternalProcessTaskBase<AzureManagedappDeleteTask>
     {
        
        /// <summary>
        /// Delete a managed application.
        /// </summary>
        public AzureManagedappDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az managedapp delete");
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
