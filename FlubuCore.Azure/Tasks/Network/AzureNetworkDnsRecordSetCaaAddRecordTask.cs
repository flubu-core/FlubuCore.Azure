
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetCaaAddRecordTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetCaaAddRecordTask>
     {
        
        /// <summary>
        /// Add a CAA record.
        /// </summary>
        public AzureNetworkDnsRecordSetCaaAddRecordTask(string flags = null ,  string recordSetName = null ,  string resourceGroup = null ,  string tag = null ,  string value = null ,  string zoneName = null)
        {
            WithArguments("az network dns record-set caa add-record");
WithArguments("--flags");
            if (!string.IsNullOrEmpty(flags))
            {
                 WithArguments(flags);
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

WithArguments("--tag");
            if (!string.IsNullOrEmpty(tag))
            {
                 WithArguments(tag);
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
