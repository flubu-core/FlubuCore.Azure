
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnSiteCreateTask : ExternalProcessTaskBase<AzureNetworkVpnSiteCreateTask>
     {
        
        /// <summary>
        /// Create a VPN site configuration.
        /// </summary>
        public AzureNetworkVpnSiteCreateTask(string ipAddress = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vpn-site create");
WithArguments("--ip-address");
            if (!string.IsNullOrEmpty(ipAddress))
            {
                 WithArguments(ipAddress);
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
        
        /// <summary>
        /// Space-separated list of CIDR address prefixes.
        /// </summary>
        public AzureNetworkVpnSiteCreateTask AddressPrefixes(string addressPrefixes = null)
        {
            WithArguments("--address-prefixes");
            if (!string.IsNullOrEmpty(addressPrefixes))
            {
                 WithArguments(addressPrefixes);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkVpnSiteCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkVpnSiteCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Whether the VPN site is security-related.
        /// </summary>
        public AzureNetworkVpnSiteCreateTask SecuritySite(string securitySite = null)
        {
            WithArguments("--security-site");
            if (!string.IsNullOrEmpty(securitySite))
            {
                 WithArguments(securitySite);
            }

            return this;
        }

        /// <summary>
        /// Key for the VPN site that can be used for connections.
        /// </summary>
        public AzureNetworkVpnSiteCreateTask SiteKey(string siteKey = null)
        {
            WithArguments("--site-key");
            if (!string.IsNullOrEmpty(siteKey))
            {
                 WithArguments(siteKey);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkVpnSiteCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the virtual WAN.
        /// </summary>
        public AzureNetworkVpnSiteCreateTask VirtualWan(string virtualWan = null)
        {
            WithArguments("--virtual-wan");
            if (!string.IsNullOrEmpty(virtualWan))
            {
                 WithArguments(virtualWan);
            }

            return this;
        }

        /// <summary>
        /// BGP speaker's ASN.
        /// </summary>
        public AzureNetworkVpnSiteCreateTask Asn(string asn = null)
        {
            WithArguments("--asn");
            if (!string.IsNullOrEmpty(asn))
            {
                 WithArguments(asn);
            }

            return this;
        }

        /// <summary>
        /// Peering address and BGP identifier of this BGP speaker.
        /// </summary>
        public AzureNetworkVpnSiteCreateTask BgpPeeringAddress(string bgpPeeringAddress = null)
        {
            WithArguments("--bgp-peering-address");
            if (!string.IsNullOrEmpty(bgpPeeringAddress))
            {
                 WithArguments(bgpPeeringAddress);
            }

            return this;
        }

        /// <summary>
        /// Weight added to routes learned from this BGP speaker.
        /// </summary>
        public AzureNetworkVpnSiteCreateTask PeerWeight(string peerWeight = null)
        {
            WithArguments("--peer-weight");
            if (!string.IsNullOrEmpty(peerWeight))
            {
                 WithArguments(peerWeight);
            }

            return this;
        }

        /// <summary>
        /// Model of the device.
        /// </summary>
        public AzureNetworkVpnSiteCreateTask DeviceModel(string deviceModel = null)
        {
            WithArguments("--device-model");
            if (!string.IsNullOrEmpty(deviceModel))
            {
                 WithArguments(deviceModel);
            }

            return this;
        }

        /// <summary>
        /// Name of the device vendor.
        /// </summary>
        public AzureNetworkVpnSiteCreateTask DeviceVendor(string deviceVendor = null)
        {
            WithArguments("--device-vendor");
            if (!string.IsNullOrEmpty(deviceVendor))
            {
                 WithArguments(deviceVendor);
            }

            return this;
        }

        /// <summary>
        /// Link speed in Mbps.
        /// </summary>
        public AzureNetworkVpnSiteCreateTask LinkSpeed(string linkSpeed = null)
        {
            WithArguments("--link-speed");
            if (!string.IsNullOrEmpty(linkSpeed))
            {
                 WithArguments(linkSpeed);
            }

            return this;
        }
     }
}
