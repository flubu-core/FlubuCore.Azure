
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsAccountTask : ExternalProcessTaskBase<AzureAmsAccountTask>
     {
        
        /// <summary>
        /// Manage Azure Media Services accounts.
        /// </summary>
        public AzureAmsAccountTask()
        {
            WithArguments("az ams account");
        }

        protected override string Description { get; set; }
        
     }
}
