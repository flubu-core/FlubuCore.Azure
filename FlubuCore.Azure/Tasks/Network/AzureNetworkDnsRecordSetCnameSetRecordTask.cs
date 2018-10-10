
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetCnameSetRecordTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetCnameSetRecordTask>
     {
        
        /// <summary>
        /// Set the value of a CNAME record.
        /// </summary>
        public AzureNetworkDnsRecordSetCnameSetRecordTask(string cname = null ,  string recordSetName = null ,  string resourceGroup = null ,  string zoneName = null)
        {
            WithArguments("az network dns record-set cname set-record");
WithArguments("--cname");
            if (!string.IsNullOrEmpty(cname))
            {
                 WithArguments(cname);
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
