
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaAccountFirewallTask : ExternalProcessTaskBase<AzureDlaAccountFirewallTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics account firewall rules.
        /// </summary>
        public AzureDlaAccountFirewallTask()
        {
            WithArguments("az dla account firewall");
        }

        protected override string Description { get; set; }
        
     }
}
