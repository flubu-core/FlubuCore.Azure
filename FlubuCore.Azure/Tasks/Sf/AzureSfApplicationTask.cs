
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfApplicationTask : ExternalProcessTaskBase<AzureSfApplicationTask>
     {
        
        /// <summary>
        /// Manage applications running on an Azure Service Fabric cluster.
        /// </summary>
        public AzureSfApplicationTask()
        {
            WithArguments("az sf application");
        }

        protected override string Description { get; set; }
        
     }
}
