
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureFeatureTask : ExternalProcessTaskBase<AzureFeatureTask>
     {
        
        /// <summary>
        /// Manage resource provider features.
        /// </summary>
        public AzureFeatureTask()
        {
            WithArguments("az feature");
        }

        protected override string Description { get; set; }
        
     }
}
