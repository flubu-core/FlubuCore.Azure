
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureManagedappTask : ExternalProcessTaskBase<AzureManagedappTask>
     {
        
        /// <summary>
        /// Manage template solutions provided and maintained by Independent Software Vendors (ISVs).
        /// </summary>
        public AzureManagedappTask()
        {
            WithArguments("az managedapp");
        }

        protected override string Description { get; set; }
        
     }
}
