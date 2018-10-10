
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnSiteDownloadTask : ExternalProcessTaskBase<AzureNetworkVpnSiteDownloadTask>
     {
        
        /// <summary>
        /// Provide a SAS-URL to download the configuration for a VPN site.
        /// </summary>
        public AzureNetworkVpnSiteDownloadTask(string resourceGroup = null ,  string vwanName = null)
        {
            WithArguments("az network vpn-site download");
WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--vwan-name");
            if (!string.IsNullOrEmpty(vwanName))
            {
                 WithArguments(vwanName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The sas-url to download the configurations for vpn-sites.
        /// </summary>
        public AzureNetworkVpnSiteDownloadTask OutputBlobSasUrl(string outputBlobSasUrl = null)
        {
            WithArguments("--output-blob-sas-url");
            if (!string.IsNullOrEmpty(outputBlobSasUrl))
            {
                 WithArguments(outputBlobSasUrl);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of VPN site names or IDs.
        /// </summary>
        public AzureNetworkVpnSiteDownloadTask VpnSites(string vpnSites = null)
        {
            WithArguments("--vpn-sites");
            if (!string.IsNullOrEmpty(vpnSites))
            {
                 WithArguments(vpnSites);
            }

            return this;
        }
     }
}
