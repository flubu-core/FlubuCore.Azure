
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnSiteUpdateTask : ExternalProcessTaskBase<AzureNetworkVpnSiteUpdateTask>
     {
        
        /// <summary>
        /// Update settings of a VPN site configuration.
        /// </summary>
        public AzureNetworkVpnSiteUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vpn-site update");
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
        public AzureNetworkVpnSiteUpdateTask AddressPrefixes(string addressPrefixes = null)
        {
            WithArguments("--address-prefixes");
            if (!string.IsNullOrEmpty(addressPrefixes))
            {
                 WithArguments(addressPrefixes);
            }

            return this;
        }

        /// <summary>
        /// IP address of the VPN site.
        /// </summary>
        public AzureNetworkVpnSiteUpdateTask IpAddress(string ipAddress = null)
        {
            WithArguments("--ip-address");
            if (!string.IsNullOrEmpty(ipAddress))
            {
                 WithArguments(ipAddress);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkVpnSiteUpdateTask NoWait(string noWait = null)
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
        public AzureNetworkVpnSiteUpdateTask SecuritySite(string securitySite = null)
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
        public AzureNetworkVpnSiteUpdateTask SiteKey(string siteKey = null)
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
        public AzureNetworkVpnSiteUpdateTask Tags(string tags = null)
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
        public AzureNetworkVpnSiteUpdateTask VirtualWan(string virtualWan = null)
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
        public AzureNetworkVpnSiteUpdateTask Asn(string asn = null)
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
        public AzureNetworkVpnSiteUpdateTask BgpPeeringAddress(string bgpPeeringAddress = null)
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
        public AzureNetworkVpnSiteUpdateTask PeerWeight(string peerWeight = null)
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
        public AzureNetworkVpnSiteUpdateTask DeviceModel(string deviceModel = null)
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
        public AzureNetworkVpnSiteUpdateTask DeviceVendor(string deviceVendor = null)
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
        public AzureNetworkVpnSiteUpdateTask LinkSpeed(string linkSpeed = null)
        {
            WithArguments("--link-speed");
            if (!string.IsNullOrEmpty(linkSpeed))
            {
                 WithArguments(linkSpeed);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkVpnSiteUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureNetworkVpnSiteUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureNetworkVpnSiteUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureNetworkVpnSiteUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
