
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureContainerTask : ExternalProcessTaskBase<AzureContainerTask>
     {
        
        /// <summary>
        /// Manage Azure Container Instances.
        /// </summary>
        public AzureContainerTask()
        {
            WithArguments("az container");
        }

        protected override string Description { get; set; }
        
     }
}
