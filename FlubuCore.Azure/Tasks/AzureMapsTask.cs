
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureMapsTask : ExternalProcessTaskBase<AzureMapsTask>
     {
        
        /// <summary>
        /// Manage Azure Maps.
        /// </summary>
        public AzureMapsTask()
        {
            WithArguments("az maps");
        }

        protected override string Description { get; set; }
        
     }
}
