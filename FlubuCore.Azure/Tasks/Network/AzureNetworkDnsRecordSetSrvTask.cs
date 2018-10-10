
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetSrvTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetSrvTask>
     {
        
        /// <summary>
        /// Manage DNS SRV records.
        /// </summary>
        public AzureNetworkDnsRecordSetSrvTask()
        {
            WithArguments("az network dns record-set srv");
        }

        protected override string Description { get; set; }
        
     }
}
