
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetSoaTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetSoaTask>
     {
        
        /// <summary>
        /// Manage a DNS SOA record.
        /// </summary>
        public AzureNetworkDnsRecordSetSoaTask()
        {
            WithArguments("az network dns record-set soa");
        }

        protected override string Description { get; set; }
        
     }
}
