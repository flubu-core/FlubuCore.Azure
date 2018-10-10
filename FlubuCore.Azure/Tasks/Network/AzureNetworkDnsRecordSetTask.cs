
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetTask>
     {
        
        /// <summary>
        /// Manage DNS records and record sets.
        /// </summary>
        public AzureNetworkDnsRecordSetTask()
        {
            WithArguments("az network dns record-set");
        }

        protected override string Description { get; set; }
        
     }
}
