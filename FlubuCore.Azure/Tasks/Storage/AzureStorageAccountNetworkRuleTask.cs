
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageAccountNetworkRuleTask : ExternalProcessTaskBase<AzureStorageAccountNetworkRuleTask>
     {
        
        /// <summary>
        /// Manage network rules.
        /// </summary>
        public AzureStorageAccountNetworkRuleTask()
        {
            WithArguments("az storage account network-rule");
        }

        protected override string Description { get; set; }
        
     }
}
