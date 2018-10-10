
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsFsTask : ExternalProcessTaskBase<AzureDlsFsTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage a Data Lake Store filesystem.
        /// </summary>
        public AzureDlsFsTask()
        {
            WithArguments("az dls fs");
        }

        protected override string Description { get; set; }
        
     }
}
