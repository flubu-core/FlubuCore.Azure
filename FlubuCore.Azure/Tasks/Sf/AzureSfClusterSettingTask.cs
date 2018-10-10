
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterSettingTask : ExternalProcessTaskBase<AzureSfClusterSettingTask>
     {
        
        /// <summary>
        /// Manage a cluster's settings.
        /// </summary>
        public AzureSfClusterSettingTask()
        {
            WithArguments("az sf cluster setting");
        }

        protected override string Description { get; set; }
        
     }
}
