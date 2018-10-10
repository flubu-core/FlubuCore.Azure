
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Provider;

namespace FlubuCore.Azure
{
    public class Provider
    {
        
        
            public AzureProviderRegisterTask ProviderRegister(string @namespace)
            {
                return new AzureProviderRegisterTask(@namespace);
            }

            public AzureProviderUnregisterTask ProviderUnregister(string @namespace)
            {
                return new AzureProviderUnregisterTask(@namespace);
            }

            public AzureProviderOperationTask ProviderOperation()
            {
                return new AzureProviderOperationTask();
            }
        
    }
}

