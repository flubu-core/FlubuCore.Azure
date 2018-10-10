
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetTxtAddRecordTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetTxtAddRecordTask>
     {
        
        /// <summary>
        /// Add a TXT record.
        /// </summary>
        public AzureNetworkDnsRecordSetTxtAddRecordTask(string recordSetName = null ,  string resourceGroup = null ,  string value = null ,  string zoneName = null)
        {
            WithArguments("az network dns record-set txt add-record");
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
        
     }
}
