
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabSecretTask : ExternalProcessTaskBase<AzureLabSecretTask>
     {
        
        /// <summary>
        /// Manage secrets of an Azure DevTest Lab.
        /// </summary>
        public AzureLabSecretTask()
        {
            WithArguments("az lab secret");
        }

        protected override string Description { get; set; }
        
     }
}
