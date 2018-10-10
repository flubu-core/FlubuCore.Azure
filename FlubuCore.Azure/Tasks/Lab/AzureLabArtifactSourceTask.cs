
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabArtifactSourceTask : ExternalProcessTaskBase<AzureLabArtifactSourceTask>
     {
        
        /// <summary>
        /// Manage DevTest Lab artifact sources.
        /// </summary>
        public AzureLabArtifactSourceTask()
        {
            WithArguments("az lab artifact-source");
        }

        protected override string Description { get; set; }
        
     }
}
