
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetMxAddRecordTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetMxAddRecordTask>
     {
        
        /// <summary>
        /// Add an MX record.
        /// </summary>
        public AzureNetworkDnsRecordSetMxAddRecordTask(string exchange = null ,  string preference = null ,  string recordSetName = null ,  string resourceGroup = null ,  string zoneName = null)
        {
            WithArguments("az network dns record-set mx add-record");
WithArguments("--exchange");
            if (!string.IsNullOrEmpty(exchange))
            {
                 WithArguments(exchange);
            }

WithArguments("--preference");
            if (!string.IsNullOrEmpty(preference))
            {
                 WithArguments(preference);
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
