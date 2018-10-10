
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaAccountDataLakeStoreTask : ExternalProcessTaskBase<AzureDlaAccountDataLakeStoreTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage links between Data Lake Analytics and Data Lake Store accounts.
        /// </summary>
        public AzureDlaAccountDataLakeStoreTask()
        {
            WithArguments("az dla account data-lake-store");
        }

        protected override string Description { get; set; }
        
     }
}
