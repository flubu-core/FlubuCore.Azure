
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Maps;

namespace FlubuCore.Azure
{
    public class Maps
    {
        
        
            public AzureMapsAccountTask MapsAccount()
            {
                return new AzureMapsAccountTask();
            }

            public AzureMapsAccountCreateTask MapsAccountCreate(string name ,  string resourceGroup)
            {
                return new AzureMapsAccountCreateTask(name,  resourceGroup);
            }

            public AzureMapsAccountDeleteTask MapsAccountDelete(string name ,  string resourceGroup)
            {
                return new AzureMapsAccountDeleteTask(name,  resourceGroup);
            }

            public AzureMapsAccountUpdateTask MapsAccountUpdate(string name ,  string resourceGroup)
            {
                return new AzureMapsAccountUpdateTask(name,  resourceGroup);
            }

            public AzureMapsAccountKeysTask MapsAccountKeys()
            {
                return new AzureMapsAccountKeysTask();
            }

            public AzureMapsAccountKeysRenewTask MapsAccountKeysRenew(string key ,  string name ,  string resourceGroup)
            {
                return new AzureMapsAccountKeysRenewTask(key,  name,  resourceGroup);
            }
        
    }
}

