
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsAccountTask : ExternalProcessTaskBase<AzureDlsAccountTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Store accounts.
        /// </summary>
        public AzureDlsAccountTask()
        {
            WithArguments("az dls account");
        }

        protected override string Description { get; set; }
        
     }
}
