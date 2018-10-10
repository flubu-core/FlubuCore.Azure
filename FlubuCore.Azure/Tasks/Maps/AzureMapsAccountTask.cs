
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Maps
{
     public partial class AzureMapsAccountTask : ExternalProcessTaskBase<AzureMapsAccountTask>
     {
        
        /// <summary>
        /// Manage Azure Maps accounts.
        /// </summary>
        public AzureMapsAccountTask()
        {
            WithArguments("az maps account");
        }

        protected override string Description { get; set; }
        
     }
}
