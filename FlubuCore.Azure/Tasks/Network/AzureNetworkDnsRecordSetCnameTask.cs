
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetCnameTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetCnameTask>
     {
        
        /// <summary>
        /// Manage DNS CNAME records.
        /// </summary>
        public AzureNetworkDnsRecordSetCnameTask()
        {
            WithArguments("az network dns record-set cname");
        }

        protected override string Description { get; set; }
        
     }
}
