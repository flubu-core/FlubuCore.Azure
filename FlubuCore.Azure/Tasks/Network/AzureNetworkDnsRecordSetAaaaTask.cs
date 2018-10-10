
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetAaaaTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetAaaaTask>
     {
        
        /// <summary>
        /// Manage DNS AAAA records.
        /// </summary>
        public AzureNetworkDnsRecordSetAaaaTask()
        {
            WithArguments("az network dns record-set aaaa");
        }

        protected override string Description { get; set; }
        
     }
}
