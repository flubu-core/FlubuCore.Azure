
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterTask : ExternalProcessTaskBase<AzureSfClusterTask>
     {
        
        /// <summary>
        /// Manage an Azure Service Fabric cluster.
        /// </summary>
        public AzureSfClusterTask()
        {
            WithArguments("az sf cluster");
        }

        protected override string Description { get; set; }
        
     }
}
