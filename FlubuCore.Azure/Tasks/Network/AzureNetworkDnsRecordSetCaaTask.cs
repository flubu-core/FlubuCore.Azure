
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetCaaTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetCaaTask>
     {
        
        /// <summary>
        /// Manage DNS CAA records.
        /// </summary>
        public AzureNetworkDnsRecordSetCaaTask()
        {
            WithArguments("az network dns record-set caa");
        }

        protected override string Description { get; set; }
        
     }
}
