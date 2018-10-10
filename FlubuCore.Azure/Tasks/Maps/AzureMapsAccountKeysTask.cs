
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Maps
{
     public partial class AzureMapsAccountKeysTask : ExternalProcessTaskBase<AzureMapsAccountKeysTask>
     {
        
        /// <summary>
        /// Manage Azure Maps account keys.
        /// </summary>
        public AzureMapsAccountKeysTask()
        {
            WithArguments("az maps account keys");
        }

        protected override string Description { get; set; }
        
     }
}
