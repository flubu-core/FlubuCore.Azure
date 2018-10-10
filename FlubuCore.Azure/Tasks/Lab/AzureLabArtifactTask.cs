
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabArtifactTask : ExternalProcessTaskBase<AzureLabArtifactTask>
     {
        
        /// <summary>
        /// Manage DevTest Labs artifacts.
        /// </summary>
        public AzureLabArtifactTask()
        {
            WithArguments("az lab artifact");
        }

        protected override string Description { get; set; }
        
     }
}
