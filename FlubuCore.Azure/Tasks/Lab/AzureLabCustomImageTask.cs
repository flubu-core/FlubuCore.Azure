
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabCustomImageTask : ExternalProcessTaskBase<AzureLabCustomImageTask>
     {
        
        /// <summary>
        /// Manage custom images of a DevTest Lab.
        /// </summary>
        public AzureLabCustomImageTask()
        {
            WithArguments("az lab custom-image");
        }

        protected override string Description { get; set; }
        
     }
}
