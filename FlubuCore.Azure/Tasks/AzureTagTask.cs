
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureTagTask : ExternalProcessTaskBase<AzureTagTask>
     {
        
        /// <summary>
        /// Manage resource tags.
        /// </summary>
        public AzureTagTask()
        {
            WithArguments("az tag");
        }

        protected override string Description { get; set; }
        
     }
}
