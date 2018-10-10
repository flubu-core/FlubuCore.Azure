
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsAccountSpTask : ExternalProcessTaskBase<AzureAmsAccountSpTask>
     {
        
        /// <summary>
        /// Manage service principal and role based access for an Azure Media Services account.
        /// </summary>
        public AzureAmsAccountSpTask()
        {
            WithArguments("az ams account sp");
        }

        protected override string Description { get; set; }
        
     }
}
