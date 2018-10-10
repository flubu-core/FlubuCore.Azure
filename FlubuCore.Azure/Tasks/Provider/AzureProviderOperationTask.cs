
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Provider
{
     public partial class AzureProviderOperationTask : ExternalProcessTaskBase<AzureProviderOperationTask>
     {
        
        /// <summary>
        /// Get provider operations metadatas.
        /// </summary>
        public AzureProviderOperationTask()
        {
            WithArguments("az provider operation");
        }

        protected override string Description { get; set; }
        
     }
}
