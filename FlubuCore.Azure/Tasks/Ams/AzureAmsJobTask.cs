
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsJobTask : ExternalProcessTaskBase<AzureAmsJobTask>
     {
        
        /// <summary>
        /// Manage jobs for a transform.
        /// </summary>
        public AzureAmsJobTask()
        {
            WithArguments("az ams job");
        }

        protected override string Description { get; set; }
        
     }
}
