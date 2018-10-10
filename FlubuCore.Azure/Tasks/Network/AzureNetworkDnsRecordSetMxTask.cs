
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetMxTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetMxTask>
     {
        
        /// <summary>
        /// Manage DNS MX records.
        /// </summary>
        public AzureNetworkDnsRecordSetMxTask()
        {
            WithArguments("az network dns record-set mx");
        }

        protected override string Description { get; set; }
        
     }
}
