
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsAccountFirewallTask : ExternalProcessTaskBase<AzureDlsAccountFirewallTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Store account firewall rules.
        /// </summary>
        public AzureDlsAccountFirewallTask()
        {
            WithArguments("az dls account firewall");
        }

        protected override string Description { get; set; }
        
     }
}
