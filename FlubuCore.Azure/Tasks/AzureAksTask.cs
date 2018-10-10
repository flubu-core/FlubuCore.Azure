
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureAksTask : ExternalProcessTaskBase<AzureAksTask>
     {
        
        /// <summary>
        /// Manage Azure Kubernetes Services.
        /// </summary>
        public AzureAksTask()
        {
            WithArguments("az aks");
        }

        protected override string Description { get; set; }
        
     }
}
