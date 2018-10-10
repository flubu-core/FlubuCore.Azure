
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabVnetTask : ExternalProcessTaskBase<AzureLabVnetTask>
     {
        
        /// <summary>
        /// Manage virtual networks of an Azure DevTest Lab.
        /// </summary>
        public AzureLabVnetTask()
        {
            WithArguments("az lab vnet");
        }

        protected override string Description { get; set; }
        
     }
}
