
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsZoneExportTask : ExternalProcessTaskBase<AzureNetworkDnsZoneExportTask>
     {
        
        /// <summary>
        /// Export a DNS zone as a DNS zone file.
        /// </summary>
        public AzureNetworkDnsZoneExportTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network dns zone export");
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

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Path to the DNS zone file to save.
        /// </summary>
        public AzureNetworkDnsZoneExportTask FileName(string fileName = null)
        {
            WithArguments("--file-name");
            if (!string.IsNullOrEmpty(fileName))
            {
                 WithArguments(fileName);
            }

            return this;
        }
     }
}
