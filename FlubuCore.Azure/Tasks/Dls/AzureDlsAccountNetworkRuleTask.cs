
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsAccountNetworkRuleTask : ExternalProcessTaskBase<AzureDlsAccountNetworkRuleTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Store account virtual network rules.
        /// </summary>
        public AzureDlsAccountNetworkRuleTask()
        {
            WithArguments("az dls account network-rule");
        }

        protected override string Description { get; set; }
        
     }
}
