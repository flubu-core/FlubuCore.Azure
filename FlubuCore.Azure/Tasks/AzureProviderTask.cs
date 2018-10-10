
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureProviderTask : ExternalProcessTaskBase<AzureProviderTask>
     {
        
        /// <summary>
        /// Manage resource providers.
        /// </summary>
        public AzureProviderTask()
        {
            WithArguments("az provider");
        }

        protected override string Description { get; set; }
        
     }
}
