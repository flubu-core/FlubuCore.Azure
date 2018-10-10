
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Search;

namespace FlubuCore.Azure
{
    public class Search
    {
        
        
            public AzureSearchAdminKeyTask SearchAdminKey()
            {
                return new AzureSearchAdminKeyTask();
            }

            public AzureSearchAdminKeyRenewTask SearchAdminKeyRenew(string keyKind ,  string resourceGroup ,  string serviceName)
            {
                return new AzureSearchAdminKeyRenewTask(keyKind,  resourceGroup,  serviceName);
            }

            public AzureSearchQueryKeyTask SearchQueryKey()
            {
                return new AzureSearchQueryKeyTask();
            }

            public AzureSearchQueryKeyCreateTask SearchQueryKeyCreate(string name ,  string resourceGroup ,  string serviceName)
            {
                return new AzureSearchQueryKeyCreateTask(name,  resourceGroup,  serviceName);
            }

            public AzureSearchQueryKeyDeleteTask SearchQueryKeyDelete(string keyValue ,  string resourceGroup ,  string serviceName)
            {
                return new AzureSearchQueryKeyDeleteTask(keyValue,  resourceGroup,  serviceName);
            }

            public AzureSearchServiceTask SearchService()
            {
                return new AzureSearchServiceTask();
            }

            public AzureSearchServiceCreateTask SearchServiceCreate(string name ,  string resourceGroup ,  string sku)
            {
                return new AzureSearchServiceCreateTask(name,  resourceGroup,  sku);
            }

            public AzureSearchServiceDeleteTask SearchServiceDelete(string name ,  string resourceGroup)
            {
                return new AzureSearchServiceDeleteTask(name,  resourceGroup);
            }

            public AzureSearchServiceUpdateTask SearchServiceUpdate(string name ,  string resourceGroup)
            {
                return new AzureSearchServiceUpdateTask(name,  resourceGroup);
            }
        
    }
}

