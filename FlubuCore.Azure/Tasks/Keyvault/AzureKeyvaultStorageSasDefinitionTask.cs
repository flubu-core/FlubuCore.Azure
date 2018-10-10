
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultStorageSasDefinitionTask : ExternalProcessTaskBase<AzureKeyvaultStorageSasDefinitionTask>
     {
        
        /// <summary>
        /// Manage storage account SAS definitions.
        /// </summary>
        public AzureKeyvaultStorageSasDefinitionTask()
        {
            WithArguments("az keyvault storage sas-definition");
        }

        protected override string Description { get; set; }
        
     }
}
