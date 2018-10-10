
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetTxtTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetTxtTask>
     {
        
        /// <summary>
        /// Manage DNS TXT records.
        /// </summary>
        public AzureNetworkDnsRecordSetTxtTask()
        {
            WithArguments("az network dns record-set txt");
        }

        protected override string Description { get; set; }
        
     }
}
