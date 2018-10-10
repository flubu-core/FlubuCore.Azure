
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Network;

namespace FlubuCore.Azure
{
    public class Network
    {
        
        
            public AzureNetworkFirewallTask NetworkFirewall()
            {
                return new AzureNetworkFirewallTask();
            }

            public AzureNetworkFirewallCreateTask NetworkFirewallCreate(string name ,  string resourceGroup)
            {
                return new AzureNetworkFirewallCreateTask(name,  resourceGroup);
            }

            public AzureNetworkFirewallDeleteTask NetworkFirewallDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkFirewallDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkFirewallUpdateTask NetworkFirewallUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkFirewallUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkFirewallApplicationRuleTask NetworkFirewallApplicationRule()
            {
                return new AzureNetworkFirewallApplicationRuleTask();
            }

            public AzureNetworkFirewallApplicationRuleCreateTask NetworkFirewallApplicationRuleCreate(string firewallName ,  string name ,  string protocols ,  string resourceGroup ,  string collectionName)
            {
                return new AzureNetworkFirewallApplicationRuleCreateTask(firewallName,  name,  protocols,  resourceGroup,  collectionName);
            }

            public AzureNetworkFirewallApplicationRuleDeleteTask NetworkFirewallApplicationRuleDelete(string collectionName ,  string firewallName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkFirewallApplicationRuleDeleteTask(collectionName,  firewallName,  name,  resourceGroup);
            }

            public AzureNetworkFirewallIpConfigTask NetworkFirewallIpConfig()
            {
                return new AzureNetworkFirewallIpConfigTask();
            }

            public AzureNetworkFirewallIpConfigCreateTask NetworkFirewallIpConfigCreate(string firewallName ,  string name ,  string publicIpAddress ,  string resourceGroup ,  string vnetName)
            {
                return new AzureNetworkFirewallIpConfigCreateTask(firewallName,  name,  publicIpAddress,  resourceGroup,  vnetName);
            }

            public AzureNetworkFirewallIpConfigDeleteTask NetworkFirewallIpConfigDelete(string firewallName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkFirewallIpConfigDeleteTask(firewallName,  name,  resourceGroup);
            }

            public AzureNetworkFirewallNatRuleTask NetworkFirewallNatRule()
            {
                return new AzureNetworkFirewallNatRuleTask();
            }

            public AzureNetworkFirewallNatRuleCreateTask NetworkFirewallNatRuleCreate(string destinationAddresses ,  string destinationPorts ,  string firewallName ,  string name ,  string protocols ,  string resourceGroup ,  string sourceAddresses ,  string translatedAddress ,  string translatedPort ,  string collectionName)
            {
                return new AzureNetworkFirewallNatRuleCreateTask(destinationAddresses,  destinationPorts,  firewallName,  name,  protocols,  resourceGroup,  sourceAddresses,  translatedAddress,  translatedPort,  collectionName);
            }

            public AzureNetworkFirewallNatRuleDeleteTask NetworkFirewallNatRuleDelete(string collectionName ,  string firewallName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkFirewallNatRuleDeleteTask(collectionName,  firewallName,  name,  resourceGroup);
            }

            public AzureNetworkFirewallNetworkRuleTask NetworkFirewallNetworkRule()
            {
                return new AzureNetworkFirewallNetworkRuleTask();
            }

            public AzureNetworkFirewallNetworkRuleCreateTask NetworkFirewallNetworkRuleCreate(string destinationAddresses ,  string destinationPorts ,  string firewallName ,  string name ,  string protocols ,  string resourceGroup ,  string sourceAddresses ,  string collectionName)
            {
                return new AzureNetworkFirewallNetworkRuleCreateTask(destinationAddresses,  destinationPorts,  firewallName,  name,  protocols,  resourceGroup,  sourceAddresses,  collectionName);
            }

            public AzureNetworkFirewallNetworkRuleDeleteTask NetworkFirewallNetworkRuleDelete(string collectionName ,  string firewallName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkFirewallNetworkRuleDeleteTask(collectionName,  firewallName,  name,  resourceGroup);
            }

            public AzureNetworkFirewallApplicationRuleCollectionTask NetworkFirewallApplicationRuleCollection()
            {
                return new AzureNetworkFirewallApplicationRuleCollectionTask();
            }

            public AzureNetworkFirewallApplicationRuleCollectionDeleteTask NetworkFirewallApplicationRuleCollectionDelete(string collectionName ,  string firewallName ,  string resourceGroup)
            {
                return new AzureNetworkFirewallApplicationRuleCollectionDeleteTask(collectionName,  firewallName,  resourceGroup);
            }

            public AzureNetworkFirewallNatRuleCollectionTask NetworkFirewallNatRuleCollection()
            {
                return new AzureNetworkFirewallNatRuleCollectionTask();
            }

            public AzureNetworkFirewallNatRuleCollectionDeleteTask NetworkFirewallNatRuleCollectionDelete(string collectionName ,  string firewallName ,  string resourceGroup)
            {
                return new AzureNetworkFirewallNatRuleCollectionDeleteTask(collectionName,  firewallName,  resourceGroup);
            }

            public AzureNetworkFirewallNetworkRuleCollectionTask NetworkFirewallNetworkRuleCollection()
            {
                return new AzureNetworkFirewallNetworkRuleCollectionTask();
            }

            public AzureNetworkFirewallNetworkRuleCollectionDeleteTask NetworkFirewallNetworkRuleCollectionDelete(string collectionName ,  string firewallName ,  string resourceGroup)
            {
                return new AzureNetworkFirewallNetworkRuleCollectionDeleteTask(collectionName,  firewallName,  resourceGroup);
            }

            public AzureNetworkDnsTask NetworkDns()
            {
                return new AzureNetworkDnsTask();
            }

            public AzureNetworkDnsZoneTask NetworkDnsZone()
            {
                return new AzureNetworkDnsZoneTask();
            }

            public AzureNetworkDnsZoneCreateTask NetworkDnsZoneCreate(string name ,  string resourceGroup)
            {
                return new AzureNetworkDnsZoneCreateTask(name,  resourceGroup);
            }

            public AzureNetworkDnsZoneUpdateTask NetworkDnsZoneUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkDnsZoneUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkExpressRouteTask NetworkExpressRoute()
            {
                return new AzureNetworkExpressRouteTask();
            }

            public AzureNetworkExpressRouteCreateTask NetworkExpressRouteCreate(string bandwidth ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRouteCreateTask(bandwidth,  name,  resourceGroup);
            }

            public AzureNetworkExpressRouteUpdateTask NetworkExpressRouteUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRouteUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkExpressRouteGatewayTask NetworkExpressRouteGateway()
            {
                return new AzureNetworkExpressRouteGatewayTask();
            }

            public AzureNetworkExpressRouteGatewayCreateTask NetworkExpressRouteGatewayCreate(string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRouteGatewayCreateTask(name,  resourceGroup);
            }

            public AzureNetworkExpressRouteGatewayDeleteTask NetworkExpressRouteGatewayDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRouteGatewayDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkExpressRouteGatewayUpdateTask NetworkExpressRouteGatewayUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRouteGatewayUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkExpressRoutePortTask NetworkExpressRoutePort()
            {
                return new AzureNetworkExpressRoutePortTask();
            }

            public AzureNetworkExpressRoutePortCreateTask NetworkExpressRoutePortCreate(string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRoutePortCreateTask(name,  resourceGroup);
            }

            public AzureNetworkExpressRoutePortDeleteTask NetworkExpressRoutePortDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRoutePortDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkExpressRoutePortUpdateTask NetworkExpressRoutePortUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRoutePortUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkExpressRouteGatewayConnectionTask NetworkExpressRouteGatewayConnection()
            {
                return new AzureNetworkExpressRouteGatewayConnectionTask();
            }

            public AzureNetworkExpressRouteGatewayConnectionCreateTask NetworkExpressRouteGatewayConnectionCreate(string gatewayName ,  string name ,  string resourceGroup ,  string peering)
            {
                return new AzureNetworkExpressRouteGatewayConnectionCreateTask(gatewayName,  name,  resourceGroup,  peering);
            }

            public AzureNetworkExpressRouteGatewayConnectionDeleteTask NetworkExpressRouteGatewayConnectionDelete(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRouteGatewayConnectionDeleteTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkExpressRouteGatewayConnectionUpdateTask NetworkExpressRouteGatewayConnectionUpdate(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRouteGatewayConnectionUpdateTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkExpressRoutePortLinkTask NetworkExpressRoutePortLink()
            {
                return new AzureNetworkExpressRoutePortLinkTask();
            }

            public AzureNetworkExpressRoutePortLocationTask NetworkExpressRoutePortLocation()
            {
                return new AzureNetworkExpressRoutePortLocationTask();
            }

            public AzureNetworkCrossConnectionTask NetworkCrossConnection()
            {
                return new AzureNetworkCrossConnectionTask();
            }

            public AzureNetworkCrossConnectionSummarizeRouteTableTask NetworkCrossConnectionSummarizeRouteTable(string devicePath ,  string name ,  string peeringName ,  string resourceGroup)
            {
                return new AzureNetworkCrossConnectionSummarizeRouteTableTask(devicePath,  name,  peeringName,  resourceGroup);
            }

            public AzureNetworkCrossConnectionUpdateTask NetworkCrossConnectionUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkCrossConnectionUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkCrossConnectionWaitTask NetworkCrossConnectionWait(string name ,  string resourceGroup)
            {
                return new AzureNetworkCrossConnectionWaitTask(name,  resourceGroup);
            }

            public AzureNetworkCrossConnectionPeeringTask NetworkCrossConnectionPeering()
            {
                return new AzureNetworkCrossConnectionPeeringTask();
            }

            public AzureNetworkCrossConnectionPeeringCreateTask NetworkCrossConnectionPeeringCreate(string crossConnectionName ,  string peerAsn ,  string peeringType ,  string primaryPeerSubnet ,  string resourceGroup ,  string secondaryPeerSubnet ,  string vlanId)
            {
                return new AzureNetworkCrossConnectionPeeringCreateTask(crossConnectionName,  peerAsn,  peeringType,  primaryPeerSubnet,  resourceGroup,  secondaryPeerSubnet,  vlanId);
            }

            public AzureNetworkCrossConnectionPeeringDeleteTask NetworkCrossConnectionPeeringDelete(string crossConnectionName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkCrossConnectionPeeringDeleteTask(crossConnectionName,  name,  resourceGroup);
            }

            public AzureNetworkCrossConnectionPeeringUpdateTask NetworkCrossConnectionPeeringUpdate(string crossConnectionName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkCrossConnectionPeeringUpdateTask(crossConnectionName,  name,  resourceGroup);
            }

            public AzureNetworkFrontDoorTask NetworkFrontDoor()
            {
                return new AzureNetworkFrontDoorTask();
            }

            public AzureNetworkFrontDoorCheckCustomDomainTask NetworkFrontDoorCheckCustomDomain(string hostName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkFrontDoorCheckCustomDomainTask(hostName,  name,  resourceGroup);
            }

            public AzureNetworkFrontDoorCreateTask NetworkFrontDoorCreate(string name ,  string resourceGroup ,  string backendAddress)
            {
                return new AzureNetworkFrontDoorCreateTask(name,  resourceGroup,  backendAddress);
            }

            public AzureNetworkFrontDoorDeleteTask NetworkFrontDoorDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkFrontDoorDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkFrontDoorPurgeEndpointTask NetworkFrontDoorPurgeEndpoint(string contentPaths ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkFrontDoorPurgeEndpointTask(contentPaths,  name,  resourceGroup);
            }

            public AzureNetworkFrontDoorUpdateTask NetworkFrontDoorUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkFrontDoorUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkWafPolicyTask NetworkWafPolicy()
            {
                return new AzureNetworkWafPolicyTask();
            }

            public AzureNetworkWafPolicyCreateTask NetworkWafPolicyCreate(string name ,  string resourceGroup)
            {
                return new AzureNetworkWafPolicyCreateTask(name,  resourceGroup);
            }

            public AzureNetworkWafPolicyDeleteTask NetworkWafPolicyDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkWafPolicyDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkWafPolicySetManagedRulesetTask NetworkWafPolicySetManagedRuleset(string name ,  string resourceGroup)
            {
                return new AzureNetworkWafPolicySetManagedRulesetTask(name,  resourceGroup);
            }

            public AzureNetworkWafPolicyUpdateTask NetworkWafPolicyUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkWafPolicyUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkFrontDoorBackendPoolTask NetworkFrontDoorBackendPool()
            {
                return new AzureNetworkFrontDoorBackendPoolTask();
            }

            public AzureNetworkFrontDoorBackendPoolCreateTask NetworkFrontDoorBackendPoolCreate(string frontDoorName ,  string loadBalancing ,  string name ,  string probe ,  string resourceGroup ,  string address)
            {
                return new AzureNetworkFrontDoorBackendPoolCreateTask(frontDoorName,  loadBalancing,  name,  probe,  resourceGroup,  address);
            }

            public AzureNetworkFrontDoorBackendPoolDeleteTask NetworkFrontDoorBackendPoolDelete(string frontDoorName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkFrontDoorBackendPoolDeleteTask(frontDoorName,  name,  resourceGroup);
            }

            public AzureNetworkFrontDoorFrontendEndpointTask NetworkFrontDoorFrontendEndpoint()
            {
                return new AzureNetworkFrontDoorFrontendEndpointTask();
            }

            public AzureNetworkFrontDoorFrontendEndpointCreateTask NetworkFrontDoorFrontendEndpointCreate(string frontDoorName ,  string hostName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkFrontDoorFrontendEndpointCreateTask(frontDoorName,  hostName,  name,  resourceGroup);
            }

            public AzureNetworkFrontDoorFrontendEndpointDeleteTask NetworkFrontDoorFrontendEndpointDelete(string frontDoorName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkFrontDoorFrontendEndpointDeleteTask(frontDoorName,  name,  resourceGroup);
            }

            public AzureNetworkFrontDoorLoadBalancingTask NetworkFrontDoorLoadBalancing()
            {
                return new AzureNetworkFrontDoorLoadBalancingTask();
            }

            public AzureNetworkFrontDoorLoadBalancingCreateTask NetworkFrontDoorLoadBalancingCreate(string frontDoorName ,  string name ,  string resourceGroup ,  string sampleSize ,  string successfulSamplesRequired)
            {
                return new AzureNetworkFrontDoorLoadBalancingCreateTask(frontDoorName,  name,  resourceGroup,  sampleSize,  successfulSamplesRequired);
            }

            public AzureNetworkFrontDoorLoadBalancingDeleteTask NetworkFrontDoorLoadBalancingDelete(string frontDoorName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkFrontDoorLoadBalancingDeleteTask(frontDoorName,  name,  resourceGroup);
            }

            public AzureNetworkFrontDoorProbeTask NetworkFrontDoorProbe()
            {
                return new AzureNetworkFrontDoorProbeTask();
            }

            public AzureNetworkFrontDoorProbeCreateTask NetworkFrontDoorProbeCreate(string frontDoorName ,  string interval ,  string name ,  string path ,  string resourceGroup)
            {
                return new AzureNetworkFrontDoorProbeCreateTask(frontDoorName,  interval,  name,  path,  resourceGroup);
            }

            public AzureNetworkFrontDoorProbeDeleteTask NetworkFrontDoorProbeDelete(string frontDoorName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkFrontDoorProbeDeleteTask(frontDoorName,  name,  resourceGroup);
            }

            public AzureNetworkFrontDoorRoutingRuleTask NetworkFrontDoorRoutingRule()
            {
                return new AzureNetworkFrontDoorRoutingRuleTask();
            }

            public AzureNetworkFrontDoorRoutingRuleCreateTask NetworkFrontDoorRoutingRuleCreate(string backendPool ,  string frontDoorName ,  string frontendEndpoints ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkFrontDoorRoutingRuleCreateTask(backendPool,  frontDoorName,  frontendEndpoints,  name,  resourceGroup);
            }

            public AzureNetworkFrontDoorRoutingRuleDeleteTask NetworkFrontDoorRoutingRuleDelete(string frontDoorName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkFrontDoorRoutingRuleDeleteTask(frontDoorName,  name,  resourceGroup);
            }

            public AzureNetworkFrontDoorBackendPoolBackendTask NetworkFrontDoorBackendPoolBackend()
            {
                return new AzureNetworkFrontDoorBackendPoolBackendTask();
            }

            public AzureNetworkFrontDoorBackendPoolBackendAddTask NetworkFrontDoorBackendPoolBackendAdd(string address ,  string frontDoorName ,  string poolName ,  string resourceGroup)
            {
                return new AzureNetworkFrontDoorBackendPoolBackendAddTask(address,  frontDoorName,  poolName,  resourceGroup);
            }

            public AzureNetworkFrontDoorBackendPoolBackendRemoveTask NetworkFrontDoorBackendPoolBackendRemove(string frontDoorName ,  string index ,  string poolName ,  string resourceGroup)
            {
                return new AzureNetworkFrontDoorBackendPoolBackendRemoveTask(frontDoorName,  index,  poolName,  resourceGroup);
            }

            public AzureNetworkWafPolicyCustomRuleTask NetworkWafPolicyCustomRule()
            {
                return new AzureNetworkWafPolicyCustomRuleTask();
            }

            public AzureNetworkWafPolicyCustomRuleCreateTask NetworkWafPolicyCustomRuleCreate(string action ,  string matchCondition ,  string name ,  string policyName ,  string priority ,  string resourceGroup ,  string ruleType)
            {
                return new AzureNetworkWafPolicyCustomRuleCreateTask(action,  matchCondition,  name,  policyName,  priority,  resourceGroup,  ruleType);
            }

            public AzureNetworkWafPolicyCustomRuleDeleteTask NetworkWafPolicyCustomRuleDelete(string name ,  string policyName ,  string resourceGroup)
            {
                return new AzureNetworkWafPolicyCustomRuleDeleteTask(name,  policyName,  resourceGroup);
            }

            public AzureNetworkNicTask NetworkNic()
            {
                return new AzureNetworkNicTask();
            }

            public AzureNetworkVnetTask NetworkVnet()
            {
                return new AzureNetworkVnetTask();
            }

            public AzureNetworkNicVtapConfigTask NetworkNicVtapConfig()
            {
                return new AzureNetworkNicVtapConfigTask();
            }

            public AzureNetworkNicVtapConfigCreateTask NetworkNicVtapConfigCreate(string name ,  string nicName ,  string resourceGroup ,  string vnetTap)
            {
                return new AzureNetworkNicVtapConfigCreateTask(name,  nicName,  resourceGroup,  vnetTap);
            }

            public AzureNetworkNicVtapConfigDeleteTask NetworkNicVtapConfigDelete(string name ,  string nicName ,  string resourceGroup)
            {
                return new AzureNetworkNicVtapConfigDeleteTask(name,  nicName,  resourceGroup);
            }

            public AzureNetworkVnetTapTask NetworkVnetTap()
            {
                return new AzureNetworkVnetTapTask();
            }

            public AzureNetworkVnetTapCreateTask NetworkVnetTapCreate(string name ,  string resourceGroup ,  string destination)
            {
                return new AzureNetworkVnetTapCreateTask(name,  resourceGroup,  destination);
            }

            public AzureNetworkVnetTapDeleteTask NetworkVnetTapDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkVnetTapDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkVnetTapUpdateTask NetworkVnetTapUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkVnetTapUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkVhubTask NetworkVhub()
            {
                return new AzureNetworkVhubTask();
            }

            public AzureNetworkVhubCreateTask NetworkVhubCreate(string addressPrefix ,  string name ,  string resourceGroup ,  string vwan)
            {
                return new AzureNetworkVhubCreateTask(addressPrefix,  name,  resourceGroup,  vwan);
            }

            public AzureNetworkVhubDeleteTask NetworkVhubDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkVhubDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkVhubUpdateTask NetworkVhubUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkVhubUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkVpnGatewayTask NetworkVpnGateway()
            {
                return new AzureNetworkVpnGatewayTask();
            }

            public AzureNetworkVpnGatewayCreateTask NetworkVpnGatewayCreate(string name ,  string resourceGroup ,  string vhub)
            {
                return new AzureNetworkVpnGatewayCreateTask(name,  resourceGroup,  vhub);
            }

            public AzureNetworkVpnGatewayDeleteTask NetworkVpnGatewayDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkVpnGatewayDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkVpnGatewayUpdateTask NetworkVpnGatewayUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkVpnGatewayUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkVpnSiteTask NetworkVpnSite()
            {
                return new AzureNetworkVpnSiteTask();
            }

            public AzureNetworkVpnSiteCreateTask NetworkVpnSiteCreate(string ipAddress ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkVpnSiteCreateTask(ipAddress,  name,  resourceGroup);
            }

            public AzureNetworkVpnSiteDeleteTask NetworkVpnSiteDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkVpnSiteDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkVpnSiteDownloadTask NetworkVpnSiteDownload(string resourceGroup ,  string vwanName)
            {
                return new AzureNetworkVpnSiteDownloadTask(resourceGroup,  vwanName);
            }

            public AzureNetworkVpnSiteUpdateTask NetworkVpnSiteUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkVpnSiteUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkVwanTask NetworkVwan()
            {
                return new AzureNetworkVwanTask();
            }

            public AzureNetworkVwanCreateTask NetworkVwanCreate(string name ,  string resourceGroup)
            {
                return new AzureNetworkVwanCreateTask(name,  resourceGroup);
            }

            public AzureNetworkVwanDeleteTask NetworkVwanDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkVwanDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkVwanUpdateTask NetworkVwanUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkVwanUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkVhubConnectionTask NetworkVhubConnection()
            {
                return new AzureNetworkVhubConnectionTask();
            }

            public AzureNetworkVhubConnectionCreateTask NetworkVhubConnectionCreate(string name ,  string remoteVnet ,  string resourceGroup ,  string vhubName)
            {
                return new AzureNetworkVhubConnectionCreateTask(name,  remoteVnet,  resourceGroup,  vhubName);
            }

            public AzureNetworkVhubConnectionDeleteTask NetworkVhubConnectionDelete(string name ,  string resourceGroup ,  string vhubName)
            {
                return new AzureNetworkVhubConnectionDeleteTask(name,  resourceGroup,  vhubName);
            }

            public AzureNetworkVhubRouteTask NetworkVhubRoute()
            {
                return new AzureNetworkVhubRouteTask();
            }

            public AzureNetworkVhubRouteAddTask NetworkVhubRouteAdd(string addressPrefixes ,  string nextHop ,  string resourceGroup ,  string vhubName)
            {
                return new AzureNetworkVhubRouteAddTask(addressPrefixes,  nextHop,  resourceGroup,  vhubName);
            }

            public AzureNetworkVhubRouteRemoveTask NetworkVhubRouteRemove(string index ,  string resourceGroup ,  string vhubName)
            {
                return new AzureNetworkVhubRouteRemoveTask(index,  resourceGroup,  vhubName);
            }

            public AzureNetworkVpnGatewayConnectionTask NetworkVpnGatewayConnection()
            {
                return new AzureNetworkVpnGatewayConnectionTask();
            }

            public AzureNetworkVpnGatewayConnectionCreateTask NetworkVpnGatewayConnectionCreate(string gatewayName ,  string name ,  string remoteVpnSite ,  string resourceGroup)
            {
                return new AzureNetworkVpnGatewayConnectionCreateTask(gatewayName,  name,  remoteVpnSite,  resourceGroup);
            }

            public AzureNetworkVpnGatewayConnectionDeleteTask NetworkVpnGatewayConnectionDelete(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkVpnGatewayConnectionDeleteTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkVpnGatewayConnectionIpsecPolicyTask NetworkVpnGatewayConnectionIpsecPolicy()
            {
                return new AzureNetworkVpnGatewayConnectionIpsecPolicyTask();
            }

            public AzureNetworkVpnGatewayConnectionIpsecPolicyAddTask NetworkVpnGatewayConnectionIpsecPolicyAdd(string connectionName ,  string gatewayName ,  string resourceGroup ,  string dhGroup ,  string ikeEncryption ,  string ikeIntegrity ,  string ipsecEncryption ,  string ipsecIntegrity ,  string pfsGroup ,  string saDataSize ,  string saLifetime)
            {
                return new AzureNetworkVpnGatewayConnectionIpsecPolicyAddTask(connectionName,  gatewayName,  resourceGroup,  dhGroup,  ikeEncryption,  ikeIntegrity,  ipsecEncryption,  ipsecIntegrity,  pfsGroup,  saDataSize,  saLifetime);
            }

            public AzureNetworkVpnGatewayConnectionIpsecPolicyRemoveTask NetworkVpnGatewayConnectionIpsecPolicyRemove(string connectionName ,  string gatewayName ,  string index ,  string resourceGroup)
            {
                return new AzureNetworkVpnGatewayConnectionIpsecPolicyRemoveTask(connectionName,  gatewayName,  index,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayTask NetworkApplicationGateway()
            {
                return new AzureNetworkApplicationGatewayTask();
            }

            public AzureNetworkApplicationGatewayCreateTask NetworkApplicationGatewayCreate(string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayCreateTask(name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayDeleteTask NetworkApplicationGatewayDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayStartTask NetworkApplicationGatewayStart(string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayStartTask(name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayStopTask NetworkApplicationGatewayStop(string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayStopTask(name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayUpdateTask NetworkApplicationGatewayUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayWaitTask NetworkApplicationGatewayWait(string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayWaitTask(name,  resourceGroup);
            }

            public AzureNetworkAsgTask NetworkAsg()
            {
                return new AzureNetworkAsgTask();
            }

            public AzureNetworkAsgCreateTask NetworkAsgCreate(string name ,  string resourceGroup)
            {
                return new AzureNetworkAsgCreateTask(name,  resourceGroup);
            }

            public AzureNetworkAsgDeleteTask NetworkAsgDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkAsgDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkAsgUpdateTask NetworkAsgUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkAsgUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkDdosProtectionTask NetworkDdosProtection()
            {
                return new AzureNetworkDdosProtectionTask();
            }

            public AzureNetworkDdosProtectionCreateTask NetworkDdosProtectionCreate(string name ,  string resourceGroup)
            {
                return new AzureNetworkDdosProtectionCreateTask(name,  resourceGroup);
            }

            public AzureNetworkDdosProtectionDeleteTask NetworkDdosProtectionDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkDdosProtectionDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkDdosProtectionUpdateTask NetworkDdosProtectionUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkDdosProtectionUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkExpressRouteDeleteTask NetworkExpressRouteDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRouteDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkExpressRouteGetStatsTask NetworkExpressRouteGetStats(string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRouteGetStatsTask(name,  resourceGroup);
            }

            public AzureNetworkExpressRouteWaitTask NetworkExpressRouteWait(string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRouteWaitTask(name,  resourceGroup);
            }

            public AzureNetworkInterfaceEndpointTask NetworkInterfaceEndpoint()
            {
                return new AzureNetworkInterfaceEndpointTask();
            }

            public AzureNetworkLbTask NetworkLb()
            {
                return new AzureNetworkLbTask();
            }

            public AzureNetworkLbCreateTask NetworkLbCreate(string name ,  string resourceGroup)
            {
                return new AzureNetworkLbCreateTask(name,  resourceGroup);
            }

            public AzureNetworkLbDeleteTask NetworkLbDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkLbDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkLbUpdateTask NetworkLbUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkLbUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkLocalGatewayTask NetworkLocalGateway()
            {
                return new AzureNetworkLocalGatewayTask();
            }

            public AzureNetworkLocalGatewayCreateTask NetworkLocalGatewayCreate(string gatewayIpAddress ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkLocalGatewayCreateTask(gatewayIpAddress,  name,  resourceGroup);
            }

            public AzureNetworkLocalGatewayDeleteTask NetworkLocalGatewayDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkLocalGatewayDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkLocalGatewayUpdateTask NetworkLocalGatewayUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkLocalGatewayUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkLocalGatewayWaitTask NetworkLocalGatewayWait(string name ,  string resourceGroup)
            {
                return new AzureNetworkLocalGatewayWaitTask(name,  resourceGroup);
            }

            public AzureNetworkNicCreateTask NetworkNicCreate(string name ,  string resourceGroup ,  string subnet)
            {
                return new AzureNetworkNicCreateTask(name,  resourceGroup,  subnet);
            }

            public AzureNetworkNicDeleteTask NetworkNicDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkNicDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkNicUpdateTask NetworkNicUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkNicUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkNicWaitTask NetworkNicWait(string name ,  string resourceGroup)
            {
                return new AzureNetworkNicWaitTask(name,  resourceGroup);
            }

            public AzureNetworkNsgTask NetworkNsg()
            {
                return new AzureNetworkNsgTask();
            }

            public AzureNetworkNsgCreateTask NetworkNsgCreate(string name ,  string resourceGroup)
            {
                return new AzureNetworkNsgCreateTask(name,  resourceGroup);
            }

            public AzureNetworkNsgDeleteTask NetworkNsgDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkNsgDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkNsgUpdateTask NetworkNsgUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkNsgUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkProfileTask NetworkProfile()
            {
                return new AzureNetworkProfileTask();
            }

            public AzureNetworkProfileDeleteTask NetworkProfileDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkProfileDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkPublicIpTask NetworkPublicIp()
            {
                return new AzureNetworkPublicIpTask();
            }

            public AzureNetworkPublicIpCreateTask NetworkPublicIpCreate(string name ,  string resourceGroup)
            {
                return new AzureNetworkPublicIpCreateTask(name,  resourceGroup);
            }

            public AzureNetworkPublicIpDeleteTask NetworkPublicIpDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkPublicIpDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkPublicIpUpdateTask NetworkPublicIpUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkPublicIpUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkRouteFilterTask NetworkRouteFilter()
            {
                return new AzureNetworkRouteFilterTask();
            }

            public AzureNetworkRouteFilterCreateTask NetworkRouteFilterCreate(string name ,  string resourceGroup)
            {
                return new AzureNetworkRouteFilterCreateTask(name,  resourceGroup);
            }

            public AzureNetworkRouteFilterDeleteTask NetworkRouteFilterDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkRouteFilterDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkRouteFilterUpdateTask NetworkRouteFilterUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkRouteFilterUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkRouteTableTask NetworkRouteTable()
            {
                return new AzureNetworkRouteTableTask();
            }

            public AzureNetworkRouteTableCreateTask NetworkRouteTableCreate(string name ,  string resourceGroup)
            {
                return new AzureNetworkRouteTableCreateTask(name,  resourceGroup);
            }

            public AzureNetworkRouteTableDeleteTask NetworkRouteTableDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkRouteTableDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkRouteTableUpdateTask NetworkRouteTableUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkRouteTableUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkServiceEndpointTask NetworkServiceEndpoint()
            {
                return new AzureNetworkServiceEndpointTask();
            }

            public AzureNetworkTrafficManagerTask NetworkTrafficManager()
            {
                return new AzureNetworkTrafficManagerTask();
            }

            public AzureNetworkVnetGatewayTask NetworkVnetGateway()
            {
                return new AzureNetworkVnetGatewayTask();
            }

            public AzureNetworkVnetGatewayCreateTask NetworkVnetGatewayCreate(string name ,  string publicIpAddresses ,  string resourceGroup ,  string vnet)
            {
                return new AzureNetworkVnetGatewayCreateTask(name,  publicIpAddresses,  resourceGroup,  vnet);
            }

            public AzureNetworkVnetGatewayDeleteTask NetworkVnetGatewayDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkVnetGatewayDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkVnetGatewayResetTask NetworkVnetGatewayReset(string name ,  string resourceGroup)
            {
                return new AzureNetworkVnetGatewayResetTask(name,  resourceGroup);
            }

            public AzureNetworkVnetGatewayUpdateTask NetworkVnetGatewayUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkVnetGatewayUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkVnetGatewayWaitTask NetworkVnetGatewayWait(string name ,  string resourceGroup)
            {
                return new AzureNetworkVnetGatewayWaitTask(name,  resourceGroup);
            }

            public AzureNetworkVnetCheckIpAddressTask NetworkVnetCheckIpAddress(string ipAddress ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkVnetCheckIpAddressTask(ipAddress,  name,  resourceGroup);
            }

            public AzureNetworkVnetCreateTask NetworkVnetCreate(string name ,  string resourceGroup)
            {
                return new AzureNetworkVnetCreateTask(name,  resourceGroup);
            }

            public AzureNetworkVnetDeleteTask NetworkVnetDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkVnetDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkVnetUpdateTask NetworkVnetUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkVnetUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkVpnConnectionTask NetworkVpnConnection()
            {
                return new AzureNetworkVpnConnectionTask();
            }

            public AzureNetworkVpnConnectionCreateTask NetworkVpnConnectionCreate(string name ,  string resourceGroup ,  string vnetGateway1)
            {
                return new AzureNetworkVpnConnectionCreateTask(name,  resourceGroup,  vnetGateway1);
            }

            public AzureNetworkVpnConnectionDeleteTask NetworkVpnConnectionDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkVpnConnectionDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkVpnConnectionUpdateTask NetworkVpnConnectionUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkVpnConnectionUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkWatcherTask NetworkWatcher()
            {
                return new AzureNetworkWatcherTask();
            }

            public AzureNetworkWatcherConfigureTask NetworkWatcherConfigure(string locations)
            {
                return new AzureNetworkWatcherConfigureTask(locations);
            }

            public AzureNetworkWatcherRunConfigurationDiagnosticTask NetworkWatcherRunConfigurationDiagnostic(string resource)
            {
                return new AzureNetworkWatcherRunConfigurationDiagnosticTask(resource);
            }

            public AzureNetworkWatcherTestConnectivityTask NetworkWatcherTestConnectivity(string sourceResource)
            {
                return new AzureNetworkWatcherTestConnectivityTask(sourceResource);
            }

            public AzureNetworkWatcherTestIpFlowTask NetworkWatcherTestIpFlow(string direction ,  string local ,  string protocol ,  string remote ,  string vm)
            {
                return new AzureNetworkWatcherTestIpFlowTask(direction,  local,  protocol,  remote,  vm);
            }

            public AzureNetworkApplicationGatewayAddressPoolTask NetworkApplicationGatewayAddressPool()
            {
                return new AzureNetworkApplicationGatewayAddressPoolTask();
            }

            public AzureNetworkApplicationGatewayAddressPoolCreateTask NetworkApplicationGatewayAddressPoolCreate(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayAddressPoolCreateTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayAddressPoolDeleteTask NetworkApplicationGatewayAddressPoolDelete(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayAddressPoolDeleteTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayAddressPoolUpdateTask NetworkApplicationGatewayAddressPoolUpdate(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayAddressPoolUpdateTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayAuthCertTask NetworkApplicationGatewayAuthCert()
            {
                return new AzureNetworkApplicationGatewayAuthCertTask();
            }

            public AzureNetworkApplicationGatewayAuthCertCreateTask NetworkApplicationGatewayAuthCertCreate(string certFile ,  string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayAuthCertCreateTask(certFile,  gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayAuthCertDeleteTask NetworkApplicationGatewayAuthCertDelete(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayAuthCertDeleteTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayAuthCertUpdateTask NetworkApplicationGatewayAuthCertUpdate(string certFile ,  string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayAuthCertUpdateTask(certFile,  gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayFrontendIpTask NetworkApplicationGatewayFrontendIp()
            {
                return new AzureNetworkApplicationGatewayFrontendIpTask();
            }

            public AzureNetworkApplicationGatewayFrontendIpCreateTask NetworkApplicationGatewayFrontendIpCreate(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayFrontendIpCreateTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayFrontendIpDeleteTask NetworkApplicationGatewayFrontendIpDelete(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayFrontendIpDeleteTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayFrontendIpUpdateTask NetworkApplicationGatewayFrontendIpUpdate(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayFrontendIpUpdateTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayFrontendPortTask NetworkApplicationGatewayFrontendPort()
            {
                return new AzureNetworkApplicationGatewayFrontendPortTask();
            }

            public AzureNetworkApplicationGatewayFrontendPortCreateTask NetworkApplicationGatewayFrontendPortCreate(string gatewayName ,  string name ,  string port ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayFrontendPortCreateTask(gatewayName,  name,  port,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayFrontendPortDeleteTask NetworkApplicationGatewayFrontendPortDelete(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayFrontendPortDeleteTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayFrontendPortUpdateTask NetworkApplicationGatewayFrontendPortUpdate(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayFrontendPortUpdateTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayHttpSettingsTask NetworkApplicationGatewayHttpSettings()
            {
                return new AzureNetworkApplicationGatewayHttpSettingsTask();
            }

            public AzureNetworkApplicationGatewayHttpSettingsCreateTask NetworkApplicationGatewayHttpSettingsCreate(string gatewayName ,  string name ,  string port ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayHttpSettingsCreateTask(gatewayName,  name,  port,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayHttpSettingsDeleteTask NetworkApplicationGatewayHttpSettingsDelete(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayHttpSettingsDeleteTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayHttpSettingsUpdateTask NetworkApplicationGatewayHttpSettingsUpdate(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayHttpSettingsUpdateTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayProbeTask NetworkApplicationGatewayProbe()
            {
                return new AzureNetworkApplicationGatewayProbeTask();
            }

            public AzureNetworkApplicationGatewayProbeCreateTask NetworkApplicationGatewayProbeCreate(string gatewayName ,  string name ,  string path ,  string protocol ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayProbeCreateTask(gatewayName,  name,  path,  protocol,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayProbeDeleteTask NetworkApplicationGatewayProbeDelete(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayProbeDeleteTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayProbeUpdateTask NetworkApplicationGatewayProbeUpdate(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayProbeUpdateTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayRedirectConfigTask NetworkApplicationGatewayRedirectConfig()
            {
                return new AzureNetworkApplicationGatewayRedirectConfigTask();
            }

            public AzureNetworkApplicationGatewayRedirectConfigCreateTask NetworkApplicationGatewayRedirectConfigCreate(string gatewayName ,  string name ,  string resourceGroup ,  string type)
            {
                return new AzureNetworkApplicationGatewayRedirectConfigCreateTask(gatewayName,  name,  resourceGroup,  type);
            }

            public AzureNetworkApplicationGatewayRedirectConfigDeleteTask NetworkApplicationGatewayRedirectConfigDelete(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayRedirectConfigDeleteTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayRedirectConfigUpdateTask NetworkApplicationGatewayRedirectConfigUpdate(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayRedirectConfigUpdateTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayRuleTask NetworkApplicationGatewayRule()
            {
                return new AzureNetworkApplicationGatewayRuleTask();
            }

            public AzureNetworkApplicationGatewayRuleCreateTask NetworkApplicationGatewayRuleCreate(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayRuleCreateTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayRuleDeleteTask NetworkApplicationGatewayRuleDelete(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayRuleDeleteTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayRuleUpdateTask NetworkApplicationGatewayRuleUpdate(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayRuleUpdateTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewaySslCertTask NetworkApplicationGatewaySslCert()
            {
                return new AzureNetworkApplicationGatewaySslCertTask();
            }

            public AzureNetworkApplicationGatewaySslCertCreateTask NetworkApplicationGatewaySslCertCreate(string certFile ,  string certPassword ,  string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewaySslCertCreateTask(certFile,  certPassword,  gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewaySslCertDeleteTask NetworkApplicationGatewaySslCertDelete(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewaySslCertDeleteTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewaySslCertUpdateTask NetworkApplicationGatewaySslCertUpdate(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewaySslCertUpdateTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewaySslPolicyTask NetworkApplicationGatewaySslPolicy()
            {
                return new AzureNetworkApplicationGatewaySslPolicyTask();
            }

            public AzureNetworkApplicationGatewaySslPolicySetTask NetworkApplicationGatewaySslPolicySet(string gatewayName ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewaySslPolicySetTask(gatewayName,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayUrlPathMapTask NetworkApplicationGatewayUrlPathMap()
            {
                return new AzureNetworkApplicationGatewayUrlPathMapTask();
            }

            public AzureNetworkApplicationGatewayUrlPathMapCreateTask NetworkApplicationGatewayUrlPathMapCreate(string gatewayName ,  string name ,  string resourceGroup ,  string paths)
            {
                return new AzureNetworkApplicationGatewayUrlPathMapCreateTask(gatewayName,  name,  resourceGroup,  paths);
            }

            public AzureNetworkApplicationGatewayUrlPathMapDeleteTask NetworkApplicationGatewayUrlPathMapDelete(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayUrlPathMapDeleteTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayUrlPathMapUpdateTask NetworkApplicationGatewayUrlPathMapUpdate(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayUrlPathMapUpdateTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayWafConfigTask NetworkApplicationGatewayWafConfig()
            {
                return new AzureNetworkApplicationGatewayWafConfigTask();
            }

            public AzureNetworkApplicationGatewayWafConfigSetTask NetworkApplicationGatewayWafConfigSet(string enabled ,  string gatewayName ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayWafConfigSetTask(enabled,  gatewayName,  resourceGroup);
            }

            public AzureNetworkApplicationGatewaySslPolicyPredefinedTask NetworkApplicationGatewaySslPolicyPredefined()
            {
                return new AzureNetworkApplicationGatewaySslPolicyPredefinedTask();
            }

            public AzureNetworkApplicationGatewayUrlPathMapRuleTask NetworkApplicationGatewayUrlPathMapRule()
            {
                return new AzureNetworkApplicationGatewayUrlPathMapRuleTask();
            }

            public AzureNetworkApplicationGatewayUrlPathMapRuleCreateTask NetworkApplicationGatewayUrlPathMapRuleCreate(string gatewayName ,  string name ,  string pathMapName ,  string paths ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayUrlPathMapRuleCreateTask(gatewayName,  name,  pathMapName,  paths,  resourceGroup);
            }

            public AzureNetworkApplicationGatewayUrlPathMapRuleDeleteTask NetworkApplicationGatewayUrlPathMapRuleDelete(string gatewayName ,  string name ,  string pathMapName ,  string resourceGroup)
            {
                return new AzureNetworkApplicationGatewayUrlPathMapRuleDeleteTask(gatewayName,  name,  pathMapName,  resourceGroup);
            }

            public AzureNetworkDnsRecordSetTask NetworkDnsRecordSet()
            {
                return new AzureNetworkDnsRecordSetTask();
            }

            public AzureNetworkDnsZoneDeleteTask NetworkDnsZoneDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkDnsZoneDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkDnsZoneExportTask NetworkDnsZoneExport(string name ,  string resourceGroup)
            {
                return new AzureNetworkDnsZoneExportTask(name,  resourceGroup);
            }

            public AzureNetworkDnsZoneImportTask NetworkDnsZoneImport(string fileName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkDnsZoneImportTask(fileName,  name,  resourceGroup);
            }

            public AzureNetworkDnsRecordSetATask NetworkDnsRecordSetA()
            {
                return new AzureNetworkDnsRecordSetATask();
            }

            public AzureNetworkDnsRecordSetAAddRecordTask NetworkDnsRecordSetAAddRecord(string ipv4Address ,  string recordSetName ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetAAddRecordTask(ipv4Address,  recordSetName,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetACreateTask NetworkDnsRecordSetACreate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetACreateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetADeleteTask NetworkDnsRecordSetADelete(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetADeleteTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetARemoveRecordTask NetworkDnsRecordSetARemoveRecord(string ipv4Address ,  string recordSetName ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetARemoveRecordTask(ipv4Address,  recordSetName,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetAUpdateTask NetworkDnsRecordSetAUpdate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetAUpdateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetAaaaTask NetworkDnsRecordSetAaaa()
            {
                return new AzureNetworkDnsRecordSetAaaaTask();
            }

            public AzureNetworkDnsRecordSetAaaaAddRecordTask NetworkDnsRecordSetAaaaAddRecord(string ipv6Address ,  string recordSetName ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetAaaaAddRecordTask(ipv6Address,  recordSetName,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetAaaaCreateTask NetworkDnsRecordSetAaaaCreate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetAaaaCreateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetAaaaDeleteTask NetworkDnsRecordSetAaaaDelete(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetAaaaDeleteTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetAaaaRemoveRecordTask NetworkDnsRecordSetAaaaRemoveRecord(string ipv6Address ,  string recordSetName ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetAaaaRemoveRecordTask(ipv6Address,  recordSetName,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetAaaaUpdateTask NetworkDnsRecordSetAaaaUpdate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetAaaaUpdateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetCaaTask NetworkDnsRecordSetCaa()
            {
                return new AzureNetworkDnsRecordSetCaaTask();
            }

            public AzureNetworkDnsRecordSetCaaAddRecordTask NetworkDnsRecordSetCaaAddRecord(string flags ,  string recordSetName ,  string resourceGroup ,  string tag ,  string value ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetCaaAddRecordTask(flags,  recordSetName,  resourceGroup,  tag,  value,  zoneName);
            }

            public AzureNetworkDnsRecordSetCaaCreateTask NetworkDnsRecordSetCaaCreate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetCaaCreateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetCaaDeleteTask NetworkDnsRecordSetCaaDelete(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetCaaDeleteTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetCaaRemoveRecordTask NetworkDnsRecordSetCaaRemoveRecord(string flags ,  string recordSetName ,  string resourceGroup ,  string tag ,  string value ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetCaaRemoveRecordTask(flags,  recordSetName,  resourceGroup,  tag,  value,  zoneName);
            }

            public AzureNetworkDnsRecordSetCaaUpdateTask NetworkDnsRecordSetCaaUpdate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetCaaUpdateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetCnameTask NetworkDnsRecordSetCname()
            {
                return new AzureNetworkDnsRecordSetCnameTask();
            }

            public AzureNetworkDnsRecordSetCnameCreateTask NetworkDnsRecordSetCnameCreate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetCnameCreateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetCnameDeleteTask NetworkDnsRecordSetCnameDelete(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetCnameDeleteTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetCnameRemoveRecordTask NetworkDnsRecordSetCnameRemoveRecord(string cname ,  string recordSetName ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetCnameRemoveRecordTask(cname,  recordSetName,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetCnameSetRecordTask NetworkDnsRecordSetCnameSetRecord(string cname ,  string recordSetName ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetCnameSetRecordTask(cname,  recordSetName,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetMxTask NetworkDnsRecordSetMx()
            {
                return new AzureNetworkDnsRecordSetMxTask();
            }

            public AzureNetworkDnsRecordSetMxAddRecordTask NetworkDnsRecordSetMxAddRecord(string exchange ,  string preference ,  string recordSetName ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetMxAddRecordTask(exchange,  preference,  recordSetName,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetMxCreateTask NetworkDnsRecordSetMxCreate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetMxCreateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetMxDeleteTask NetworkDnsRecordSetMxDelete(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetMxDeleteTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetMxRemoveRecordTask NetworkDnsRecordSetMxRemoveRecord(string exchange ,  string preference ,  string recordSetName ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetMxRemoveRecordTask(exchange,  preference,  recordSetName,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetMxUpdateTask NetworkDnsRecordSetMxUpdate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetMxUpdateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetNsTask NetworkDnsRecordSetNs()
            {
                return new AzureNetworkDnsRecordSetNsTask();
            }

            public AzureNetworkDnsRecordSetNsAddRecordTask NetworkDnsRecordSetNsAddRecord(string nsdname ,  string recordSetName ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetNsAddRecordTask(nsdname,  recordSetName,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetNsCreateTask NetworkDnsRecordSetNsCreate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetNsCreateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetNsDeleteTask NetworkDnsRecordSetNsDelete(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetNsDeleteTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetNsRemoveRecordTask NetworkDnsRecordSetNsRemoveRecord(string nsdname ,  string recordSetName ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetNsRemoveRecordTask(nsdname,  recordSetName,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetNsUpdateTask NetworkDnsRecordSetNsUpdate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetNsUpdateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetPtrTask NetworkDnsRecordSetPtr()
            {
                return new AzureNetworkDnsRecordSetPtrTask();
            }

            public AzureNetworkDnsRecordSetPtrAddRecordTask NetworkDnsRecordSetPtrAddRecord(string ptrdname ,  string recordSetName ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetPtrAddRecordTask(ptrdname,  recordSetName,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetPtrCreateTask NetworkDnsRecordSetPtrCreate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetPtrCreateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetPtrDeleteTask NetworkDnsRecordSetPtrDelete(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetPtrDeleteTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetPtrRemoveRecordTask NetworkDnsRecordSetPtrRemoveRecord(string ptrdname ,  string recordSetName ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetPtrRemoveRecordTask(ptrdname,  recordSetName,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetPtrUpdateTask NetworkDnsRecordSetPtrUpdate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetPtrUpdateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetSoaTask NetworkDnsRecordSetSoa()
            {
                return new AzureNetworkDnsRecordSetSoaTask();
            }

            public AzureNetworkDnsRecordSetSoaUpdateTask NetworkDnsRecordSetSoaUpdate(string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetSoaUpdateTask(resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetSrvTask NetworkDnsRecordSetSrv()
            {
                return new AzureNetworkDnsRecordSetSrvTask();
            }

            public AzureNetworkDnsRecordSetSrvAddRecordTask NetworkDnsRecordSetSrvAddRecord(string port ,  string priority ,  string recordSetName ,  string resourceGroup ,  string target ,  string weight ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetSrvAddRecordTask(port,  priority,  recordSetName,  resourceGroup,  target,  weight,  zoneName);
            }

            public AzureNetworkDnsRecordSetSrvCreateTask NetworkDnsRecordSetSrvCreate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetSrvCreateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetSrvDeleteTask NetworkDnsRecordSetSrvDelete(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetSrvDeleteTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetSrvRemoveRecordTask NetworkDnsRecordSetSrvRemoveRecord(string port ,  string priority ,  string recordSetName ,  string resourceGroup ,  string target ,  string weight ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetSrvRemoveRecordTask(port,  priority,  recordSetName,  resourceGroup,  target,  weight,  zoneName);
            }

            public AzureNetworkDnsRecordSetSrvUpdateTask NetworkDnsRecordSetSrvUpdate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetSrvUpdateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetTxtTask NetworkDnsRecordSetTxt()
            {
                return new AzureNetworkDnsRecordSetTxtTask();
            }

            public AzureNetworkDnsRecordSetTxtAddRecordTask NetworkDnsRecordSetTxtAddRecord(string recordSetName ,  string resourceGroup ,  string value ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetTxtAddRecordTask(recordSetName,  resourceGroup,  value,  zoneName);
            }

            public AzureNetworkDnsRecordSetTxtCreateTask NetworkDnsRecordSetTxtCreate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetTxtCreateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetTxtDeleteTask NetworkDnsRecordSetTxtDelete(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetTxtDeleteTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkDnsRecordSetTxtRemoveRecordTask NetworkDnsRecordSetTxtRemoveRecord(string recordSetName ,  string resourceGroup ,  string value ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetTxtRemoveRecordTask(recordSetName,  resourceGroup,  value,  zoneName);
            }

            public AzureNetworkDnsRecordSetTxtUpdateTask NetworkDnsRecordSetTxtUpdate(string name ,  string resourceGroup ,  string zoneName)
            {
                return new AzureNetworkDnsRecordSetTxtUpdateTask(name,  resourceGroup,  zoneName);
            }

            public AzureNetworkExpressRouteAuthTask NetworkExpressRouteAuth()
            {
                return new AzureNetworkExpressRouteAuthTask();
            }

            public AzureNetworkExpressRouteAuthCreateTask NetworkExpressRouteAuthCreate(string circuitName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRouteAuthCreateTask(circuitName,  name,  resourceGroup);
            }

            public AzureNetworkExpressRouteAuthDeleteTask NetworkExpressRouteAuthDelete(string circuitName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRouteAuthDeleteTask(circuitName,  name,  resourceGroup);
            }

            public AzureNetworkExpressRoutePeeringTask NetworkExpressRoutePeering()
            {
                return new AzureNetworkExpressRoutePeeringTask();
            }

            public AzureNetworkExpressRoutePeeringCreateTask NetworkExpressRoutePeeringCreate(string circuitName ,  string peerAsn ,  string peeringType ,  string primaryPeerSubnet ,  string resourceGroup ,  string secondaryPeerSubnet ,  string vlanId)
            {
                return new AzureNetworkExpressRoutePeeringCreateTask(circuitName,  peerAsn,  peeringType,  primaryPeerSubnet,  resourceGroup,  secondaryPeerSubnet,  vlanId);
            }

            public AzureNetworkExpressRoutePeeringDeleteTask NetworkExpressRoutePeeringDelete(string circuitName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRoutePeeringDeleteTask(circuitName,  name,  resourceGroup);
            }

            public AzureNetworkExpressRoutePeeringUpdateTask NetworkExpressRoutePeeringUpdate(string circuitName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkExpressRoutePeeringUpdateTask(circuitName,  name,  resourceGroup);
            }

            public AzureNetworkExpressRoutePeeringConnectionTask NetworkExpressRoutePeeringConnection()
            {
                return new AzureNetworkExpressRoutePeeringConnectionTask();
            }

            public AzureNetworkExpressRoutePeeringConnectionCreateTask NetworkExpressRoutePeeringConnectionCreate(string addressPrefix ,  string circuitName ,  string name ,  string peerCircuit ,  string peeringName ,  string resourceGroup)
            {
                return new AzureNetworkExpressRoutePeeringConnectionCreateTask(addressPrefix,  circuitName,  name,  peerCircuit,  peeringName,  resourceGroup);
            }

            public AzureNetworkExpressRoutePeeringConnectionDeleteTask NetworkExpressRoutePeeringConnectionDelete(string circuitName ,  string name ,  string peeringName ,  string resourceGroup)
            {
                return new AzureNetworkExpressRoutePeeringConnectionDeleteTask(circuitName,  name,  peeringName,  resourceGroup);
            }

            public AzureNetworkLbAddressPoolTask NetworkLbAddressPool()
            {
                return new AzureNetworkLbAddressPoolTask();
            }

            public AzureNetworkLbAddressPoolCreateTask NetworkLbAddressPoolCreate(string lbName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkLbAddressPoolCreateTask(lbName,  name,  resourceGroup);
            }

            public AzureNetworkLbAddressPoolDeleteTask NetworkLbAddressPoolDelete(string lbName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkLbAddressPoolDeleteTask(lbName,  name,  resourceGroup);
            }

            public AzureNetworkLbFrontendIpTask NetworkLbFrontendIp()
            {
                return new AzureNetworkLbFrontendIpTask();
            }

            public AzureNetworkLbFrontendIpCreateTask NetworkLbFrontendIpCreate(string lbName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkLbFrontendIpCreateTask(lbName,  name,  resourceGroup);
            }

            public AzureNetworkLbFrontendIpDeleteTask NetworkLbFrontendIpDelete(string lbName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkLbFrontendIpDeleteTask(lbName,  name,  resourceGroup);
            }

            public AzureNetworkLbFrontendIpUpdateTask NetworkLbFrontendIpUpdate(string lbName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkLbFrontendIpUpdateTask(lbName,  name,  resourceGroup);
            }

            public AzureNetworkLbInboundNatPoolTask NetworkLbInboundNatPool()
            {
                return new AzureNetworkLbInboundNatPoolTask();
            }

            public AzureNetworkLbInboundNatPoolCreateTask NetworkLbInboundNatPoolCreate(string backendPort ,  string frontendPortRangeEnd ,  string frontendPortRangeStart ,  string lbName ,  string name ,  string protocol ,  string resourceGroup)
            {
                return new AzureNetworkLbInboundNatPoolCreateTask(backendPort,  frontendPortRangeEnd,  frontendPortRangeStart,  lbName,  name,  protocol,  resourceGroup);
            }

            public AzureNetworkLbInboundNatPoolDeleteTask NetworkLbInboundNatPoolDelete(string lbName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkLbInboundNatPoolDeleteTask(lbName,  name,  resourceGroup);
            }

            public AzureNetworkLbInboundNatPoolUpdateTask NetworkLbInboundNatPoolUpdate(string lbName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkLbInboundNatPoolUpdateTask(lbName,  name,  resourceGroup);
            }

            public AzureNetworkLbInboundNatRuleTask NetworkLbInboundNatRule()
            {
                return new AzureNetworkLbInboundNatRuleTask();
            }

            public AzureNetworkLbInboundNatRuleCreateTask NetworkLbInboundNatRuleCreate(string backendPort ,  string frontendPort ,  string lbName ,  string name ,  string protocol ,  string resourceGroup)
            {
                return new AzureNetworkLbInboundNatRuleCreateTask(backendPort,  frontendPort,  lbName,  name,  protocol,  resourceGroup);
            }

            public AzureNetworkLbInboundNatRuleDeleteTask NetworkLbInboundNatRuleDelete(string lbName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkLbInboundNatRuleDeleteTask(lbName,  name,  resourceGroup);
            }

            public AzureNetworkLbInboundNatRuleUpdateTask NetworkLbInboundNatRuleUpdate(string lbName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkLbInboundNatRuleUpdateTask(lbName,  name,  resourceGroup);
            }

            public AzureNetworkLbOutboundRuleTask NetworkLbOutboundRule()
            {
                return new AzureNetworkLbOutboundRuleTask();
            }

            public AzureNetworkLbOutboundRuleCreateTask NetworkLbOutboundRuleCreate(string addressPool ,  string frontendIpConfigs ,  string lbName ,  string name ,  string protocol ,  string resourceGroup)
            {
                return new AzureNetworkLbOutboundRuleCreateTask(addressPool,  frontendIpConfigs,  lbName,  name,  protocol,  resourceGroup);
            }

            public AzureNetworkLbOutboundRuleDeleteTask NetworkLbOutboundRuleDelete(string lbName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkLbOutboundRuleDeleteTask(lbName,  name,  resourceGroup);
            }

            public AzureNetworkLbOutboundRuleUpdateTask NetworkLbOutboundRuleUpdate(string lbName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkLbOutboundRuleUpdateTask(lbName,  name,  resourceGroup);
            }

            public AzureNetworkLbProbeTask NetworkLbProbe()
            {
                return new AzureNetworkLbProbeTask();
            }

            public AzureNetworkLbProbeCreateTask NetworkLbProbeCreate(string lbName ,  string name ,  string port ,  string protocol ,  string resourceGroup)
            {
                return new AzureNetworkLbProbeCreateTask(lbName,  name,  port,  protocol,  resourceGroup);
            }

            public AzureNetworkLbProbeDeleteTask NetworkLbProbeDelete(string lbName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkLbProbeDeleteTask(lbName,  name,  resourceGroup);
            }

            public AzureNetworkLbProbeUpdateTask NetworkLbProbeUpdate(string lbName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkLbProbeUpdateTask(lbName,  name,  resourceGroup);
            }

            public AzureNetworkLbRuleTask NetworkLbRule()
            {
                return new AzureNetworkLbRuleTask();
            }

            public AzureNetworkLbRuleCreateTask NetworkLbRuleCreate(string backendPort ,  string frontendPort ,  string lbName ,  string name ,  string protocol ,  string resourceGroup)
            {
                return new AzureNetworkLbRuleCreateTask(backendPort,  frontendPort,  lbName,  name,  protocol,  resourceGroup);
            }

            public AzureNetworkLbRuleDeleteTask NetworkLbRuleDelete(string lbName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkLbRuleDeleteTask(lbName,  name,  resourceGroup);
            }

            public AzureNetworkLbRuleUpdateTask NetworkLbRuleUpdate(string lbName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkLbRuleUpdateTask(lbName,  name,  resourceGroup);
            }

            public AzureNetworkNicIpConfigTask NetworkNicIpConfig()
            {
                return new AzureNetworkNicIpConfigTask();
            }

            public AzureNetworkNicIpConfigCreateTask NetworkNicIpConfigCreate(string name ,  string nicName ,  string resourceGroup)
            {
                return new AzureNetworkNicIpConfigCreateTask(name,  nicName,  resourceGroup);
            }

            public AzureNetworkNicIpConfigDeleteTask NetworkNicIpConfigDelete(string name ,  string nicName ,  string resourceGroup)
            {
                return new AzureNetworkNicIpConfigDeleteTask(name,  nicName,  resourceGroup);
            }

            public AzureNetworkNicIpConfigUpdateTask NetworkNicIpConfigUpdate(string name ,  string nicName ,  string resourceGroup)
            {
                return new AzureNetworkNicIpConfigUpdateTask(name,  nicName,  resourceGroup);
            }

            public AzureNetworkNicIpConfigAddressPoolTask NetworkNicIpConfigAddressPool()
            {
                return new AzureNetworkNicIpConfigAddressPoolTask();
            }

            public AzureNetworkNicIpConfigAddressPoolAddTask NetworkNicIpConfigAddressPoolAdd(string addressPool ,  string ipConfigName ,  string nicName ,  string resourceGroup)
            {
                return new AzureNetworkNicIpConfigAddressPoolAddTask(addressPool,  ipConfigName,  nicName,  resourceGroup);
            }

            public AzureNetworkNicIpConfigAddressPoolRemoveTask NetworkNicIpConfigAddressPoolRemove(string addressPool ,  string ipConfigName ,  string nicName ,  string resourceGroup)
            {
                return new AzureNetworkNicIpConfigAddressPoolRemoveTask(addressPool,  ipConfigName,  nicName,  resourceGroup);
            }

            public AzureNetworkNicIpConfigInboundNatRuleTask NetworkNicIpConfigInboundNatRule()
            {
                return new AzureNetworkNicIpConfigInboundNatRuleTask();
            }

            public AzureNetworkNicIpConfigInboundNatRuleAddTask NetworkNicIpConfigInboundNatRuleAdd(string inboundNatRule ,  string ipConfigName ,  string nicName ,  string resourceGroup)
            {
                return new AzureNetworkNicIpConfigInboundNatRuleAddTask(inboundNatRule,  ipConfigName,  nicName,  resourceGroup);
            }

            public AzureNetworkNicIpConfigInboundNatRuleRemoveTask NetworkNicIpConfigInboundNatRuleRemove(string inboundNatRule ,  string ipConfigName ,  string nicName ,  string resourceGroup)
            {
                return new AzureNetworkNicIpConfigInboundNatRuleRemoveTask(inboundNatRule,  ipConfigName,  nicName,  resourceGroup);
            }

            public AzureNetworkNsgRuleTask NetworkNsgRule()
            {
                return new AzureNetworkNsgRuleTask();
            }

            public AzureNetworkNsgRuleCreateTask NetworkNsgRuleCreate(string name ,  string nsgName ,  string priority ,  string resourceGroup)
            {
                return new AzureNetworkNsgRuleCreateTask(name,  nsgName,  priority,  resourceGroup);
            }

            public AzureNetworkNsgRuleDeleteTask NetworkNsgRuleDelete(string name ,  string nsgName ,  string resourceGroup)
            {
                return new AzureNetworkNsgRuleDeleteTask(name,  nsgName,  resourceGroup);
            }

            public AzureNetworkNsgRuleUpdateTask NetworkNsgRuleUpdate(string name ,  string nsgName ,  string resourceGroup)
            {
                return new AzureNetworkNsgRuleUpdateTask(name,  nsgName,  resourceGroup);
            }

            public AzureNetworkPublicIpPrefixTask NetworkPublicIpPrefix()
            {
                return new AzureNetworkPublicIpPrefixTask();
            }

            public AzureNetworkPublicIpPrefixCreateTask NetworkPublicIpPrefixCreate(string length ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkPublicIpPrefixCreateTask(length,  name,  resourceGroup);
            }

            public AzureNetworkPublicIpPrefixDeleteTask NetworkPublicIpPrefixDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkPublicIpPrefixDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkPublicIpPrefixUpdateTask NetworkPublicIpPrefixUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkPublicIpPrefixUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkRouteFilterRuleTask NetworkRouteFilterRule()
            {
                return new AzureNetworkRouteFilterRuleTask();
            }

            public AzureNetworkRouteFilterRuleCreateTask NetworkRouteFilterRuleCreate(string access ,  string communities ,  string filterName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkRouteFilterRuleCreateTask(access,  communities,  filterName,  name,  resourceGroup);
            }

            public AzureNetworkRouteFilterRuleDeleteTask NetworkRouteFilterRuleDelete(string filterName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkRouteFilterRuleDeleteTask(filterName,  name,  resourceGroup);
            }

            public AzureNetworkRouteFilterRuleUpdateTask NetworkRouteFilterRuleUpdate(string filterName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkRouteFilterRuleUpdateTask(filterName,  name,  resourceGroup);
            }

            public AzureNetworkRouteTableRouteTask NetworkRouteTableRoute()
            {
                return new AzureNetworkRouteTableRouteTask();
            }

            public AzureNetworkRouteTableRouteCreateTask NetworkRouteTableRouteCreate(string addressPrefix ,  string name ,  string nextHopType ,  string resourceGroup ,  string routeTableName)
            {
                return new AzureNetworkRouteTableRouteCreateTask(addressPrefix,  name,  nextHopType,  resourceGroup,  routeTableName);
            }

            public AzureNetworkRouteTableRouteDeleteTask NetworkRouteTableRouteDelete(string name ,  string resourceGroup ,  string routeTableName)
            {
                return new AzureNetworkRouteTableRouteDeleteTask(name,  resourceGroup,  routeTableName);
            }

            public AzureNetworkRouteTableRouteUpdateTask NetworkRouteTableRouteUpdate(string name ,  string resourceGroup ,  string routeTableName)
            {
                return new AzureNetworkRouteTableRouteUpdateTask(name,  resourceGroup,  routeTableName);
            }

            public AzureNetworkServiceEndpointPolicyDefinitionTask NetworkServiceEndpointPolicyDefinition()
            {
                return new AzureNetworkServiceEndpointPolicyDefinitionTask();
            }

            public AzureNetworkServiceEndpointPolicyDefinitionCreateTask NetworkServiceEndpointPolicyDefinitionCreate(string name ,  string policyName ,  string resourceGroup ,  string service ,  string serviceResources)
            {
                return new AzureNetworkServiceEndpointPolicyDefinitionCreateTask(name,  policyName,  resourceGroup,  service,  serviceResources);
            }

            public AzureNetworkServiceEndpointPolicyDefinitionDeleteTask NetworkServiceEndpointPolicyDefinitionDelete(string name ,  string policyName ,  string resourceGroup)
            {
                return new AzureNetworkServiceEndpointPolicyDefinitionDeleteTask(name,  policyName,  resourceGroup);
            }

            public AzureNetworkServiceEndpointPolicyDefinitionUpdateTask NetworkServiceEndpointPolicyDefinitionUpdate(string name ,  string policyName ,  string resourceGroup)
            {
                return new AzureNetworkServiceEndpointPolicyDefinitionUpdateTask(name,  policyName,  resourceGroup);
            }

            public AzureNetworkServiceEndpointPolicyTask NetworkServiceEndpointPolicy()
            {
                return new AzureNetworkServiceEndpointPolicyTask();
            }

            public AzureNetworkServiceEndpointPolicyCreateTask NetworkServiceEndpointPolicyCreate(string name ,  string resourceGroup)
            {
                return new AzureNetworkServiceEndpointPolicyCreateTask(name,  resourceGroup);
            }

            public AzureNetworkServiceEndpointPolicyDeleteTask NetworkServiceEndpointPolicyDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkServiceEndpointPolicyDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkServiceEndpointPolicyUpdateTask NetworkServiceEndpointPolicyUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkServiceEndpointPolicyUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkTrafficManagerEndpointTask NetworkTrafficManagerEndpoint()
            {
                return new AzureNetworkTrafficManagerEndpointTask();
            }

            public AzureNetworkTrafficManagerEndpointCreateTask NetworkTrafficManagerEndpointCreate(string name ,  string profileName ,  string resourceGroup ,  string type)
            {
                return new AzureNetworkTrafficManagerEndpointCreateTask(name,  profileName,  resourceGroup,  type);
            }

            public AzureNetworkTrafficManagerEndpointDeleteTask NetworkTrafficManagerEndpointDelete(string name ,  string profileName ,  string resourceGroup ,  string type)
            {
                return new AzureNetworkTrafficManagerEndpointDeleteTask(name,  profileName,  resourceGroup,  type);
            }

            public AzureNetworkTrafficManagerEndpointUpdateTask NetworkTrafficManagerEndpointUpdate(string name ,  string profileName ,  string resourceGroup)
            {
                return new AzureNetworkTrafficManagerEndpointUpdateTask(name,  profileName,  resourceGroup);
            }

            public AzureNetworkTrafficManagerProfileTask NetworkTrafficManagerProfile()
            {
                return new AzureNetworkTrafficManagerProfileTask();
            }

            public AzureNetworkTrafficManagerProfileCheckDnsTask NetworkTrafficManagerProfileCheckDns(string name)
            {
                return new AzureNetworkTrafficManagerProfileCheckDnsTask(name);
            }

            public AzureNetworkTrafficManagerProfileCreateTask NetworkTrafficManagerProfileCreate(string name ,  string resourceGroup ,  string routingMethod ,  string uniqueDnsName)
            {
                return new AzureNetworkTrafficManagerProfileCreateTask(name,  resourceGroup,  routingMethod,  uniqueDnsName);
            }

            public AzureNetworkTrafficManagerProfileDeleteTask NetworkTrafficManagerProfileDelete(string name ,  string resourceGroup)
            {
                return new AzureNetworkTrafficManagerProfileDeleteTask(name,  resourceGroup);
            }

            public AzureNetworkTrafficManagerProfileUpdateTask NetworkTrafficManagerProfileUpdate(string name ,  string resourceGroup)
            {
                return new AzureNetworkTrafficManagerProfileUpdateTask(name,  resourceGroup);
            }

            public AzureNetworkVnetPeeringTask NetworkVnetPeering()
            {
                return new AzureNetworkVnetPeeringTask();
            }

            public AzureNetworkVnetPeeringCreateTask NetworkVnetPeeringCreate(string name ,  string remoteVnetId ,  string resourceGroup ,  string vnetName)
            {
                return new AzureNetworkVnetPeeringCreateTask(name,  remoteVnetId,  resourceGroup,  vnetName);
            }

            public AzureNetworkVnetPeeringDeleteTask NetworkVnetPeeringDelete(string name ,  string resourceGroup ,  string vnetName)
            {
                return new AzureNetworkVnetPeeringDeleteTask(name,  resourceGroup,  vnetName);
            }

            public AzureNetworkVnetPeeringUpdateTask NetworkVnetPeeringUpdate(string name ,  string resourceGroup ,  string vnetName)
            {
                return new AzureNetworkVnetPeeringUpdateTask(name,  resourceGroup,  vnetName);
            }

            public AzureNetworkVnetSubnetTask NetworkVnetSubnet()
            {
                return new AzureNetworkVnetSubnetTask();
            }

            public AzureNetworkVnetSubnetCreateTask NetworkVnetSubnetCreate(string addressPrefix ,  string name ,  string resourceGroup ,  string vnetName)
            {
                return new AzureNetworkVnetSubnetCreateTask(addressPrefix,  name,  resourceGroup,  vnetName);
            }

            public AzureNetworkVnetSubnetDeleteTask NetworkVnetSubnetDelete(string name ,  string resourceGroup ,  string vnetName)
            {
                return new AzureNetworkVnetSubnetDeleteTask(name,  resourceGroup,  vnetName);
            }

            public AzureNetworkVnetSubnetUpdateTask NetworkVnetSubnetUpdate(string name ,  string resourceGroup ,  string vnetName)
            {
                return new AzureNetworkVnetSubnetUpdateTask(name,  resourceGroup,  vnetName);
            }

            public AzureNetworkVnetGatewayRevokedCertTask NetworkVnetGatewayRevokedCert()
            {
                return new AzureNetworkVnetGatewayRevokedCertTask();
            }

            public AzureNetworkVnetGatewayRevokedCertCreateTask NetworkVnetGatewayRevokedCertCreate(string gatewayName ,  string name ,  string resourceGroup ,  string thumbprint)
            {
                return new AzureNetworkVnetGatewayRevokedCertCreateTask(gatewayName,  name,  resourceGroup,  thumbprint);
            }

            public AzureNetworkVnetGatewayRevokedCertDeleteTask NetworkVnetGatewayRevokedCertDelete(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkVnetGatewayRevokedCertDeleteTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkVnetGatewayRootCertTask NetworkVnetGatewayRootCert()
            {
                return new AzureNetworkVnetGatewayRootCertTask();
            }

            public AzureNetworkVnetGatewayRootCertCreateTask NetworkVnetGatewayRootCertCreate(string gatewayName ,  string name ,  string publicCertData ,  string resourceGroup)
            {
                return new AzureNetworkVnetGatewayRootCertCreateTask(gatewayName,  name,  publicCertData,  resourceGroup);
            }

            public AzureNetworkVnetGatewayRootCertDeleteTask NetworkVnetGatewayRootCertDelete(string gatewayName ,  string name ,  string resourceGroup)
            {
                return new AzureNetworkVnetGatewayRootCertDeleteTask(gatewayName,  name,  resourceGroup);
            }

            public AzureNetworkVnetGatewayVpnClientTask NetworkVnetGatewayVpnClient()
            {
                return new AzureNetworkVnetGatewayVpnClientTask();
            }

            public AzureNetworkVnetGatewayVpnClientGenerateTask NetworkVnetGatewayVpnClientGenerate(string name ,  string resourceGroup)
            {
                return new AzureNetworkVnetGatewayVpnClientGenerateTask(name,  resourceGroup);
            }

            public AzureNetworkVpnConnectionIpsecPolicyTask NetworkVpnConnectionIpsecPolicy()
            {
                return new AzureNetworkVpnConnectionIpsecPolicyTask();
            }

            public AzureNetworkVpnConnectionIpsecPolicyAddTask NetworkVpnConnectionIpsecPolicyAdd(string connectionName ,  string dhGroup ,  string ikeEncryption ,  string ikeIntegrity ,  string ipsecEncryption ,  string ipsecIntegrity ,  string pfsGroup ,  string resourceGroup ,  string saLifetime ,  string saMaxSize)
            {
                return new AzureNetworkVpnConnectionIpsecPolicyAddTask(connectionName,  dhGroup,  ikeEncryption,  ikeIntegrity,  ipsecEncryption,  ipsecIntegrity,  pfsGroup,  resourceGroup,  saLifetime,  saMaxSize);
            }

            public AzureNetworkVpnConnectionIpsecPolicyClearTask NetworkVpnConnectionIpsecPolicyClear(string connectionName ,  string resourceGroup)
            {
                return new AzureNetworkVpnConnectionIpsecPolicyClearTask(connectionName,  resourceGroup);
            }

            public AzureNetworkVpnConnectionSharedKeyTask NetworkVpnConnectionSharedKey()
            {
                return new AzureNetworkVpnConnectionSharedKeyTask();
            }

            public AzureNetworkVpnConnectionSharedKeyResetTask NetworkVpnConnectionSharedKeyReset(string connectionName ,  string keyLength ,  string resourceGroup)
            {
                return new AzureNetworkVpnConnectionSharedKeyResetTask(connectionName,  keyLength,  resourceGroup);
            }

            public AzureNetworkVpnConnectionSharedKeyUpdateTask NetworkVpnConnectionSharedKeyUpdate(string connectionName ,  string resourceGroup ,  string value)
            {
                return new AzureNetworkVpnConnectionSharedKeyUpdateTask(connectionName,  resourceGroup,  value);
            }

            public AzureNetworkWatcherConnectionMonitorTask NetworkWatcherConnectionMonitor()
            {
                return new AzureNetworkWatcherConnectionMonitorTask();
            }

            public AzureNetworkWatcherConnectionMonitorCreateTask NetworkWatcherConnectionMonitorCreate(string name ,  string sourceResource)
            {
                return new AzureNetworkWatcherConnectionMonitorCreateTask(name,  sourceResource);
            }

            public AzureNetworkWatcherConnectionMonitorDeleteTask NetworkWatcherConnectionMonitorDelete(string location ,  string name)
            {
                return new AzureNetworkWatcherConnectionMonitorDeleteTask(location,  name);
            }

            public AzureNetworkWatcherConnectionMonitorQueryTask NetworkWatcherConnectionMonitorQuery(string location ,  string name)
            {
                return new AzureNetworkWatcherConnectionMonitorQueryTask(location,  name);
            }

            public AzureNetworkWatcherConnectionMonitorStartTask NetworkWatcherConnectionMonitorStart(string location ,  string name)
            {
                return new AzureNetworkWatcherConnectionMonitorStartTask(location,  name);
            }

            public AzureNetworkWatcherConnectionMonitorStopTask NetworkWatcherConnectionMonitorStop(string location ,  string name)
            {
                return new AzureNetworkWatcherConnectionMonitorStopTask(location,  name);
            }

            public AzureNetworkWatcherFlowLogTask NetworkWatcherFlowLog()
            {
                return new AzureNetworkWatcherFlowLogTask();
            }

            public AzureNetworkWatcherFlowLogConfigureTask NetworkWatcherFlowLogConfigure(string nsg)
            {
                return new AzureNetworkWatcherFlowLogConfigureTask(nsg);
            }

            public AzureNetworkWatcherPacketCaptureTask NetworkWatcherPacketCapture()
            {
                return new AzureNetworkWatcherPacketCaptureTask();
            }

            public AzureNetworkWatcherPacketCaptureCreateTask NetworkWatcherPacketCaptureCreate(string name ,  string resourceGroup ,  string vm)
            {
                return new AzureNetworkWatcherPacketCaptureCreateTask(name,  resourceGroup,  vm);
            }

            public AzureNetworkWatcherPacketCaptureDeleteTask NetworkWatcherPacketCaptureDelete(string location ,  string name)
            {
                return new AzureNetworkWatcherPacketCaptureDeleteTask(location,  name);
            }

            public AzureNetworkWatcherPacketCaptureStopTask NetworkWatcherPacketCaptureStop(string location ,  string name)
            {
                return new AzureNetworkWatcherPacketCaptureStopTask(location,  name);
            }

            public AzureNetworkWatcherTroubleshootingTask NetworkWatcherTroubleshooting()
            {
                return new AzureNetworkWatcherTroubleshootingTask();
            }

            public AzureNetworkWatcherTroubleshootingStartTask NetworkWatcherTroubleshootingStart(string resource ,  string storageAccount ,  string storagePath)
            {
                return new AzureNetworkWatcherTroubleshootingStartTask(resource,  storageAccount,  storagePath);
            }
        
    }
}

