
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaCatalogTablePartitionTask : ExternalProcessTaskBase<AzureDlaCatalogTablePartitionTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics catalog table partitions.
        /// </summary>
        public AzureDlaCatalogTablePartitionTask()
        {
            WithArguments("az dla catalog table-partition");
        }

        protected override string Description { get; set; }
        
     }
}
