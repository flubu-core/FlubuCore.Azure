
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acs
{
     public partial class AzureAcsDcosTask : ExternalProcessTaskBase<AzureAcsDcosTask>
     {
        
        /// <summary>
        /// Commands to manage a DC/OS-orchestrated Azure Container Service.
        /// </summary>
        public AzureAcsDcosTask()
        {
            WithArguments("az acs dcos");
        }

        protected override string Description { get; set; }
        
     }
}
