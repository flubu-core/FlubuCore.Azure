
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetNsAddRecordTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetNsAddRecordTask>
     {
        
        /// <summary>
        /// Add an NS record.
        /// </summary>
        public AzureNetworkDnsRecordSetNsAddRecordTask(string nsdname = null ,  string recordSetName = null ,  string resourceGroup = null ,  string zoneName = null)
        {
            WithArguments("az network dns record-set ns add-record");
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
        
     }
}
