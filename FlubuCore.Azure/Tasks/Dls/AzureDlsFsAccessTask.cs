
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsFsAccessTask : ExternalProcessTaskBase<AzureDlsFsAccessTask>
     {
        
        /// <summary>
        /// Manage Data Lake Store filesystem access and permissions.
        /// </summary>
        public AzureDlsFsAccessTask()
        {
            WithArguments("az dls fs access");
        }

        protected override string Description { get; set; }
        
     }
}
