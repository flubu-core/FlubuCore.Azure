
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetNsRemoveRecordTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetNsRemoveRecordTask>
     {
        
        /// <summary>
        /// Remove an NS record from its record set.
        /// </summary>
        public AzureNetworkDnsRecordSetNsRemoveRecordTask(string nsdname = null ,  string recordSetName = null ,  string resourceGroup = null ,  string zoneName = null)
        {
            WithArguments("az network dns record-set ns remove-record");
WithArguments("--nsdname");
            if (!string.IsNullOrEmpty(nsdname))
            {
                 WithArguments(nsdname);
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
        public AzureNetworkDnsRecordSetNsRemoveRecordTask KeepEmptyRecordSet(string keepEmptyRecordSet = null)
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
