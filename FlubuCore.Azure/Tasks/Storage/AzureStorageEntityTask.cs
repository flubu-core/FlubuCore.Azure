
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageEntityTask : ExternalProcessTaskBase<AzureStorageEntityTask>
     {
        
        /// <summary>
        /// Manage table storage entities.
        /// </summary>
        public AzureStorageEntityTask()
        {
            WithArguments("az storage entity");
        }

        protected override string Description { get; set; }
        
     }
}
