
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetSrvAddRecordTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetSrvAddRecordTask>
     {
        
        /// <summary>
        /// Add an SRV record.
        /// </summary>
        public AzureNetworkDnsRecordSetSrvAddRecordTask(string port = null ,  string priority = null ,  string recordSetName = null ,  string resourceGroup = null ,  string target = null ,  string weight = null ,  string zoneName = null)
        {
            WithArguments("az network dns record-set srv add-record");
WithArguments("--port");
            if (!string.IsNullOrEmpty(port))
            {
                 WithArguments(port);
            }

WithArguments("--priority");
            if (!string.IsNullOrEmpty(priority))
            {
                 WithArguments(priority);
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

WithArguments("--target");
            if (!string.IsNullOrEmpty(target))
            {
                 WithArguments(target);
            }

WithArguments("--weight");
            if (!string.IsNullOrEmpty(weight))
            {
                 WithArguments(weight);
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
