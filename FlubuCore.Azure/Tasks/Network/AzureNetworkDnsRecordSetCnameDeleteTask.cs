
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetCnameDeleteTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetCnameDeleteTask>
     {
        
        /// <summary>
        /// Delete a CNAME record set and its associated record.
        /// </summary>
        public AzureNetworkDnsRecordSetCnameDeleteTask(string name = null ,  string resourceGroup = null ,  string zoneName = null)
        {
            WithArguments("az network dns record-set cname delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
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
        /// The etag of the record set. Omit this value to always delete the current record set. Specify the last-seen etag value to prevent accidentally deleting any concurrent changes.
        /// </summary>
        public AzureNetworkDnsRecordSetCnameDeleteTask IfMatch(string ifMatch = null)
        {
            WithArguments("--if-match");
            if (!string.IsNullOrEmpty(ifMatch))
            {
                 WithArguments(ifMatch);
            }

            return this;
        }
     }
}
