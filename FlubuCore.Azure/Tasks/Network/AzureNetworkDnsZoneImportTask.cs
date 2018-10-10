
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsZoneImportTask : ExternalProcessTaskBase<AzureNetworkDnsZoneImportTask>
     {
        
        /// <summary>
        /// Create a DNS zone using a DNS zone file.
        /// </summary>
        public AzureNetworkDnsZoneImportTask(string fileName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network dns zone import");
WithArguments("--file-name");
            if (!string.IsNullOrEmpty(fileName))
            {
                 WithArguments(fileName);
            }

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
        
     }
}
