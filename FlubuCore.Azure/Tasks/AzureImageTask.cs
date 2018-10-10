
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureImageTask : ExternalProcessTaskBase<AzureImageTask>
     {
        
        /// <summary>
        /// Manage custom virtual machine images.
        /// </summary>
        public AzureImageTask()
        {
            WithArguments("az image");
        }

        protected override string Description { get; set; }
        
     }
}
