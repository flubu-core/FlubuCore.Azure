
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetTxtRemoveRecordTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetTxtRemoveRecordTask>
     {
        
        /// <summary>
        /// Remove a TXT record from its record set.
        /// </summary>
        public AzureNetworkDnsRecordSetTxtRemoveRecordTask(string recordSetName = null ,  string resourceGroup = null ,  string value = null ,  string zoneName = null)
        {
            WithArguments("az network dns record-set txt remove-record");
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

WithArguments("--value");
            if (!string.IsNullOrEmpty(value))
            {
                 WithArguments(value);
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
        public AzureNetworkDnsRecordSetTxtRemoveRecordTask KeepEmptyRecordSet(string keepEmptyRecordSet = null)
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
