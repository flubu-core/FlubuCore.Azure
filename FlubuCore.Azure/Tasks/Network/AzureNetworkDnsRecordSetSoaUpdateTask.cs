
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsRecordSetSoaUpdateTask : ExternalProcessTaskBase<AzureNetworkDnsRecordSetSoaUpdateTask>
     {
        
        /// <summary>
        /// Update properties of an SOA record.
        /// </summary>
        public AzureNetworkDnsRecordSetSoaUpdateTask(string resourceGroup = null ,  string zoneName = null)
        {
            WithArguments("az network dns record-set soa update");
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
        /// Email address.
        /// </summary>
        public AzureNetworkDnsRecordSetSoaUpdateTask Email(string email = null)
        {
            WithArguments("--email");
            if (!string.IsNullOrEmpty(email))
            {
                 WithArguments(email);
            }

            return this;
        }

        /// <summary>
        /// Expire time (seconds).
        /// </summary>
        public AzureNetworkDnsRecordSetSoaUpdateTask ExpireTime(string expireTime = null)
        {
            WithArguments("--expire-time");
            if (!string.IsNullOrEmpty(expireTime))
            {
                 WithArguments(expireTime);
            }

            return this;
        }

        /// <summary>
        /// Host name.
        /// </summary>
        public AzureNetworkDnsRecordSetSoaUpdateTask Host(string host = null)
        {
            WithArguments("--host");
            if (!string.IsNullOrEmpty(host))
            {
                 WithArguments(host);
            }

            return this;
        }

        /// <summary>
        /// Minimum TTL (time-to-live, seconds).
        /// </summary>
        public AzureNetworkDnsRecordSetSoaUpdateTask MinimumTtl(string minimumTtl = null)
        {
            WithArguments("--minimum-ttl");
            if (!string.IsNullOrEmpty(minimumTtl))
            {
                 WithArguments(minimumTtl);
            }

            return this;
        }

        /// <summary>
        /// Refresh value (seconds).
        /// </summary>
        public AzureNetworkDnsRecordSetSoaUpdateTask RefreshTime(string refreshTime = null)
        {
            WithArguments("--refresh-time");
            if (!string.IsNullOrEmpty(refreshTime))
            {
                 WithArguments(refreshTime);
            }

            return this;
        }

        /// <summary>
        /// Retry time (seconds).
        /// </summary>
        public AzureNetworkDnsRecordSetSoaUpdateTask RetryTime(string retryTime = null)
        {
            WithArguments("--retry-time");
            if (!string.IsNullOrEmpty(retryTime))
            {
                 WithArguments(retryTime);
            }

            return this;
        }

        /// <summary>
        /// Serial number.
        /// </summary>
        public AzureNetworkDnsRecordSetSoaUpdateTask SerialNumber(string serialNumber = null)
        {
            WithArguments("--serial-number");
            if (!string.IsNullOrEmpty(serialNumber))
            {
                 WithArguments(serialNumber);
            }

            return this;
        }
     }
}
