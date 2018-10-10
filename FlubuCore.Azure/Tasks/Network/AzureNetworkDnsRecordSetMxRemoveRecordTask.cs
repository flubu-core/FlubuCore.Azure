
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetMxRemoveRecordTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetMxRemoveRecordTask>
     {
        
        /// <summary>
        /// Remove an MX record from its record set.
        /// </summary>
        public AzureNetworkDnsRecordSetMxRemoveRecordTask(string exchange = null ,  string preference = null ,  string recordSetName = null ,  string resourceGroup = null ,  string zoneName = null)
        {
            WithArguments("az network dns record-set mx remove-record");
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
        
        /// <summary>
        /// Keep the empty record set if the last record is removed.
        /// </summary>
        public AzureNetworkDnsRecordSetMxRemoveRecordTask KeepEmptyRecordSet(string keepEmptyRecordSet = null)
        {
            WithArguments("--keep-empty-record-set");
            if (!string.IsNullOrEmpty(keepEmptyRecordSet))
            {
                 WithArguments(keepEmptyRecordSet);
            }

            return this;
        }
     }
}
