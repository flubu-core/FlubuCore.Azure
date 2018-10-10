
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetPtrTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetPtrTask>
     {
        
        /// <summary>
        /// Manage DNS PTR records.
        /// </summary>
        public AzureNetworkDnsRecordSetPtrTask()
        {
            WithArguments("az network dns record-set ptr");
        }

        protected override string Description { get; set; }
        
     }
}
