
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetAaaaAddRecordTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetAaaaAddRecordTask>
     {
        
        /// <summary>
        /// Add an AAAA record.
        /// </summary>
        public AzureNetworkDnsRecordSetAaaaAddRecordTask(string ipv6Address = null ,  string recordSetName = null ,  string resourceGroup = null ,  string zoneName = null)
        {
            WithArguments("az network dns record-set aaaa add-record");
WithArguments("--ipv6-address");
            if (!string.IsNullOrEmpty(ipv6Address))
            {
                 WithArguments(ipv6Address);
            }

WithArguments("--record-set-name");
            if (!string.IsNullOrEmpty(recordSetName))
            {
                 WithArguments(recordSetName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--zone-name");
            if (!string.IsNullOrEmpty(zoneName))
            {
                 WithArguments(zoneName);
            }

        }

        protected override string Description { get; set; }
        
     }
}
