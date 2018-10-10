
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaAccountTask : ExternalProcessTaskBase<AzureDlaAccountTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics accounts.
        /// </summary>
        public AzureDlaAccountTask()
        {
            WithArguments("az dla account");
        }

        protected override string Description { get; set; }
        
     }
}
