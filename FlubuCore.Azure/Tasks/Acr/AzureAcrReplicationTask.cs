
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrReplicationTask : ExternalProcessTaskBase<AzureAcrReplicationTask>
     {
        
        /// <summary>
        /// Manage geo-replicated regions of Azure Container Registries.
        /// </summary>
        public AzureAcrReplicationTask()
        {
            WithArguments("az acr replication");
        }

        protected override string Description { get; set; }
        
     }
}
