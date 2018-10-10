
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Managedapp
{
     public partial class AzureManagedappDefinitionTask : ExternalProcessTaskBase<AzureManagedappDefinitionTask>
     {
        
        /// <summary>
        /// Manage Azure Managed Applications.
        /// </summary>
        public AzureManagedappDefinitionTask()
        {
            WithArguments("az managedapp definition");
        }

        protected override string Description { get; set; }
        
     }
}
