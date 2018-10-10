
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetAaaaDeleteTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetAaaaDeleteTask>
     {
        
        /// <summary>
        /// Delete an AAAA record set and all associated records.
        /// </summary>
        public AzureNetworkDnsRecordSetAaaaDeleteTask(string name = null ,  string resourceGroup = null ,  string zoneName = null)
        {
            WithArguments("az network dns record-set aaaa delete");
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
        public AzureNetworkDnsRecordSetAaaaDeleteTask IfMatch(string ifMatch = null)
        {
            WithArguments("--if-match");
            if (!string.IsNullOrEmpty(ifMatch))
            {
                 WithArguments(ifMatch);
            }

            return this;
        }

        /// <summary>
        /// Do not prompt for confirmation.
        /// </summary>
        public AzureNetworkDnsRecordSetAaaaDeleteTask Yes(string yes = null)
        {
            WithArguments("--yes");
            if (!string.IsNullOrEmpty(yes))
            {
                 WithArguments(yes);
            }

            return this;
        }
     }
}
