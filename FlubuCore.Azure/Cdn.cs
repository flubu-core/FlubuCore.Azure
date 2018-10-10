
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Cdn;

namespace FlubuCore.Azure
{
    public class Cdn
    {
        
        
            public AzureCdnNameExistsTask CdnNameExists(string name)
            {
                return new AzureCdnNameExistsTask(name);
            }

            public AzureCdnUsageTask CdnUsage()
            {
                return new AzureCdnUsageTask();
            }

            public AzureCdnCustomDomainTask CdnCustomDomain()
            {
                return new AzureCdnCustomDomainTask();
            }

            public AzureCdnCustomDomainCreateTask CdnCustomDomainCreate(string endpointName ,  string hostname ,  string name ,  string profileName ,  string resourceGroup)
            {
                return new AzureCdnCustomDomainCreateTask(endpointName,  hostname,  name,  profileName,  resourceGroup);
            }

            public AzureCdnCustomDomainDeleteTask CdnCustomDomainDelete(string endpointName ,  string name ,  string profileName ,  string resourceGroup)
            {
                return new AzureCdnCustomDomainDeleteTask(endpointName,  name,  profileName,  resourceGroup);
            }

            public AzureCdnCustomDomainDisableHttpsTask CdnCustomDomainDisableHttps(string endpointName ,  string name ,  string profileName ,  string resourceGroup)
            {
                return new AzureCdnCustomDomainDisableHttpsTask(endpointName,  name,  profileName,  resourceGroup);
            }

            public AzureCdnCustomDomainEnableHttpsTask CdnCustomDomainEnableHttps(string endpointName ,  string name ,  string profileName ,  string resourceGroup)
            {
                return new AzureCdnCustomDomainEnableHttpsTask(endpointName,  name,  profileName,  resourceGroup);
            }

            public AzureCdnEdgeNodeTask CdnEdgeNode()
            {
                return new AzureCdnEdgeNodeTask();
            }

            public AzureCdnEndpointTask CdnEndpoint()
            {
                return new AzureCdnEndpointTask();
            }

            public AzureCdnEndpointCreateTask CdnEndpointCreate(string name ,  string origin ,  string profileName ,  string resourceGroup)
            {
                return new AzureCdnEndpointCreateTask(name,  origin,  profileName,  resourceGroup);
            }

            public AzureCdnEndpointDeleteTask CdnEndpointDelete(string name ,  string profileName ,  string resourceGroup)
            {
                return new AzureCdnEndpointDeleteTask(name,  profileName,  resourceGroup);
            }

            public AzureCdnEndpointLoadTask CdnEndpointLoad(string contentPaths ,  string name ,  string profileName ,  string resourceGroup)
            {
                return new AzureCdnEndpointLoadTask(contentPaths,  name,  profileName,  resourceGroup);
            }

            public AzureCdnEndpointPurgeTask CdnEndpointPurge(string contentPaths ,  string name ,  string profileName ,  string resourceGroup)
            {
                return new AzureCdnEndpointPurgeTask(contentPaths,  name,  profileName,  resourceGroup);
            }

            public AzureCdnEndpointStartTask CdnEndpointStart(string name ,  string profileName ,  string resourceGroup)
            {
                return new AzureCdnEndpointStartTask(name,  profileName,  resourceGroup);
            }

            public AzureCdnEndpointStopTask CdnEndpointStop(string name ,  string profileName ,  string resourceGroup)
            {
                return new AzureCdnEndpointStopTask(name,  profileName,  resourceGroup);
            }

            public AzureCdnEndpointUpdateTask CdnEndpointUpdate(string name ,  string profileName ,  string resourceGroup)
            {
                return new AzureCdnEndpointUpdateTask(name,  profileName,  resourceGroup);
            }

            public AzureCdnEndpointValidateCustomDomainTask CdnEndpointValidateCustomDomain(string hostName ,  string name ,  string profileName ,  string resourceGroup)
            {
                return new AzureCdnEndpointValidateCustomDomainTask(hostName,  name,  profileName,  resourceGroup);
            }

            public AzureCdnOriginTask CdnOrigin()
            {
                return new AzureCdnOriginTask();
            }

            public AzureCdnProfileTask CdnProfile()
            {
                return new AzureCdnProfileTask();
            }

            public AzureCdnProfileCreateTask CdnProfileCreate(string name ,  string resourceGroup)
            {
                return new AzureCdnProfileCreateTask(name,  resourceGroup);
            }

            public AzureCdnProfileDeleteTask CdnProfileDelete(string name ,  string resourceGroup)
            {
                return new AzureCdnProfileDeleteTask(name,  resourceGroup);
            }

            public AzureCdnProfileUpdateTask CdnProfileUpdate(string name ,  string resourceGroup)
            {
                return new AzureCdnProfileUpdateTask(name,  resourceGroup);
            }

            public AzureCdnProfileUsageTask CdnProfileUsage(string name ,  string resourceGroup)
            {
                return new AzureCdnProfileUsageTask(name,  resourceGroup);
            }
        
    }
}

