
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetSrvCreateTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetSrvCreateTask>
     {
        
        /// <summary>
        /// Create an empty SRV record set.
        /// </summary>
        public AzureNetworkDnsRecordSetSrvCreateTask(string name = null ,  string resourceGroup = null ,  string zoneName = null)
        {
            WithArguments("az network dns record-set srv create");
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
        /// The etag of the record set. Omit this value to always overwrite the current record set. Specify the last-seen etag value to prevent accidentally overwritting any concurrent changes.
        /// </summary>
        public AzureNetworkDnsRecordSetSrvCreateTask IfMatch(string ifMatch = null)
        {
            WithArguments("--if-match");
            if (!string.IsNullOrEmpty(ifMatch))
            {
                 WithArguments(ifMatch);
            }

            return this;
        }

        /// <summary>
        /// Create the record set only if it does not already exist.
        /// </summary>
        public AzureNetworkDnsRecordSetSrvCreateTask IfNoneMatch(string ifNoneMatch = null)
        {
            WithArguments("--if-none-match");
            if (!string.IsNullOrEmpty(ifNoneMatch))
            {
                 WithArguments(ifNoneMatch);
            }

            return this;
        }

        /// <summary>
        /// Metadata in space-separated key=value pairs. This overwrites any existing metadata.
        /// </summary>
        public AzureNetworkDnsRecordSetSrvCreateTask Metadata(string metadata = null)
        {
            WithArguments("--metadata");
            if (!string.IsNullOrEmpty(metadata))
            {
                 WithArguments(metadata);
            }

            return this;
        }

        /// <summary>
        /// ID of an Azure resource from which the DNS resource value is taken.
        /// </summary>
        public AzureNetworkDnsRecordSetSrvCreateTask TargetResource(string targetResource = null)
        {
            WithArguments("--target-resource");
            if (!string.IsNullOrEmpty(targetResource))
            {
                 WithArguments(targetResource);
            }

            return this;
        }

        /// <summary>
        /// Record set TTL (time-to-live).
        /// </summary>
        public AzureNetworkDnsRecordSetSrvCreateTask Ttl(string ttl = null)
        {
            WithArguments("--ttl");
            if (!string.IsNullOrEmpty(ttl))
            {
                 WithArguments(ttl);
            }

            return this;
        }
     }
}
