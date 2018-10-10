
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsStreamingLocatorTask : ExternalProcessTaskBase<AzureAmsStreamingLocatorTask>
     {
        
        /// <summary>
        /// Manage streaming locators for an Azure Media Services account.
        /// </summary>
        public AzureAmsStreamingLocatorTask()
        {
            WithArguments("az ams streaming locator");
        }

        protected override string Description { get; set; }
        
     }
}
