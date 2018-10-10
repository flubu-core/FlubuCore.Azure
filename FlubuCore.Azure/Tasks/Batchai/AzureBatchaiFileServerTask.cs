
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiFileServerTask : ExternalProcessTaskBase<AzureBatchaiFileServerTask>
     {
        
        /// <summary>
        /// Commands to manage file servers.
        /// </summary>
        public AzureBatchaiFileServerTask()
        {
            WithArguments("az batchai file-server");
        }

        protected override string Description { get; set; }
        
     }
}
