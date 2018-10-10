
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureDlsTask : ExternalProcessTaskBase<AzureDlsTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Store accounts and filesystems.
        /// </summary>
        public AzureDlsTask()
        {
            WithArguments("az dls");
        }

        protected override string Description { get; set; }
        
     }
}
