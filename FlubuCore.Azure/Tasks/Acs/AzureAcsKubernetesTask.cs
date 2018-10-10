
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acs
{
     public partial class AzureAcsKubernetesTask : ExternalProcessTaskBase<AzureAcsKubernetesTask>
     {
        
        /// <summary>
        /// Commands to manage a Kubernetes-orchestrated Azure Container Service.
        /// </summary>
        public AzureAcsKubernetesTask()
        {
            WithArguments("az acs kubernetes");
        }

        protected override string Description { get; set; }
        
     }
}
