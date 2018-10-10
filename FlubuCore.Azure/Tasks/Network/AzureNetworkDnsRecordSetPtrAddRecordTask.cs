
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetPtrAddRecordTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetPtrAddRecordTask>
     {
        
        /// <summary>
        /// Add a PTR record.
        /// </summary>
        public AzureNetworkDnsRecordSetPtrAddRecordTask(string ptrdname = null ,  string recordSetName = null ,  string resourceGroup = null ,  string zoneName = null)
        {
            WithArguments("az network dns record-set ptr add-record");
WithArguments("--ptrdname");
            if (!string.IsNullOrEmpty(ptrdname))
            {
                 WithArguments(ptrdname);
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
