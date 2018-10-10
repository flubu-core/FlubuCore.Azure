
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetNsTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetNsTask>
     {
        
        /// <summary>
        /// Manage DNS NS records.
        /// </summary>
        public AzureNetworkDnsRecordSetNsTask()
        {
            WithArguments("az network dns record-set ns");
        }

        protected override string Description { get; set; }
        
     }
}
