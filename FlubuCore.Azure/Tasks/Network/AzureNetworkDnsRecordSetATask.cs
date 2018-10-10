
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetATask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetATask>
     {
        
        /// <summary>
        /// Manage DNS A records.
        /// </summary>
        public AzureNetworkDnsRecordSetATask()
        {
            WithArguments("az network dns record-set a");
        }

        protected override string Description { get; set; }
        
     }
}
