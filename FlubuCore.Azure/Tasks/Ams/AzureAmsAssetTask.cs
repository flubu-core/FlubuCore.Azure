
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsAssetTask : ExternalProcessTaskBase<AzureAmsAssetTask>
     {
        
        /// <summary>
        /// Manage assets for an Azure Media Services account.
        /// </summary>
        public AzureAmsAssetTask()
        {
            WithArguments("az ams asset");
        }

        protected override string Description { get; set; }
        
     }
}
