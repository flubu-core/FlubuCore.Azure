
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsAccountStorageTask : ExternalProcessTaskBase<AzureAmsAccountStorageTask>
     {
        
        /// <summary>
        /// Manage secondary storage for an Azure Media Services account.
        /// </summary>
        public AzureAmsAccountStorageTask()
        {
            WithArguments("az ams account storage");
        }

        protected override string Description { get; set; }
        
     }
}
