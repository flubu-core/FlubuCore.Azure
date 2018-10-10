
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Managedapp
{
     public partial class AzureManagedappDefinitionDeleteTask : ExternalProcessTaskBase<AzureManagedappDefinitionDeleteTask>
     {
        
        /// <summary>
        /// Delete a managed application definition.
        /// </summary>
        public AzureManagedappDefinitionDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az managedapp definition delete");
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
