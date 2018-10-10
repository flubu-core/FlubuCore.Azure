
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetAAddRecordTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetAAddRecordTask>
     {
        
        /// <summary>
        /// Add an A record.
        /// </summary>
        public AzureNetworkDnsRecordSetAAddRecordTask(string ipv4Address = null ,  string recordSetName = null ,  string resourceGroup = null ,  string zoneName = null)
        {
            WithArguments("az network dns record-set a add-record");
WithArguments("--ipv4-address");
            if (!string.IsNullOrEmpty(ipv4Address))
            {
                 WithArguments(ipv4Address);
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
