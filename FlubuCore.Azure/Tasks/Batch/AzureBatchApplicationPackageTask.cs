
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchApplicationPackageTask : ExternalProcessTaskBase<AzureBatchApplicationPackageTask>
     {
        
        /// <summary>
        /// Manage Batch application packages.
        /// </summary>
        public AzureBatchApplicationPackageTask()
        {
            WithArguments("az batch application package");
        }

        protected override string Description { get; set; }
        
     }
}
